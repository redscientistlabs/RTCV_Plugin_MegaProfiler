namespace PLUGIN_MEGAPROFILER.UI
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using NLog;
    using RTCV.CorruptCore;
    using RTCV.NetCore;
    using RTCV.Common;
    using RTCV.UI;
    using static RTCV.CorruptCore.RtcCore;
    using RTCV.Vanguard;
    using System.IO;
    using System.Text.RegularExpressions;
    using Eocron;
    using System.Diagnostics;
    using System.Security.Cryptography;

    public partial class PluginForm : Form
    {
        public PLUGIN_MEGAPROFILER plugin;

        public volatile bool HideOnClose = true;

        Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public PluginForm(PLUGIN_MEGAPROFILER _plugin)
        {
            plugin = _plugin;

            this.InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.PluginForm_FormClosing);


            this.Text = PLUGIN_MEGAPROFILER.CamelCase(nameof(PLUGIN_MEGAPROFILER).Replace("_", " ")) + $" - Version {plugin.Version.ToString()}"; //automatic window title

            this.cbAsmSpec.Items.Clear();
            cbAsmSpec.DataSource = Enum.GetNames(typeof(AsmLanguage));
        }



        private void PluginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HideOnClose)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void btnLoadDomains_Click(object sender, EventArgs e)
        {
            S.GET<MemoryDomainsForm>().RefreshDomainsAndKeepSelected();
            var temp = cbSelectedMemoryDomain.SelectedItem;

            cbSelectedMemoryDomain.Items.Clear();
            var domains = MemoryDomains.MemoryInterfaces?.Keys.Where(it => !it.Contains("[V]")).ToArray();
            if (domains?.Length > 0)
            {
                cbSelectedMemoryDomain.Items.AddRange(domains);
            }

            if (temp != null && cbSelectedMemoryDomain.Items.Contains(temp))
            {
                cbSelectedMemoryDomain.SelectedItem = temp;
            }
            else if (cbSelectedMemoryDomain.Items.Count > 0)
            {
                cbSelectedMemoryDomain.SelectedIndex = 0;
            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            MemoryInterface mi = MemoryDomains.GetInterface(cbSelectedMemoryDomain.SelectedItem.ToString());
            if (mi == null)
            {
                MessageBox.Show("The currently selected domain doesn't exist!\nMake sure you have the correct core loaded and you've refreshed the domains.");
                return;
            }

            long domainSize = MemoryDomains.GetInterface(cbSelectedMemoryDomain.SelectedItem.ToString()).Size;

            List<long> hitAddresses = new List<long>();

            var instructions = AsmSpec.GSpecs[(AsmLanguage)cbAsmSpec.SelectedIndex].Instructions;
            var inslens = AsmSpec.GSpecs[(AsmLanguage)cbAsmSpec.SelectedIndex].InstructionLengths;

            byte[] dump = mi.PeekBytes(0, mi.Size, true);

            for (int i = 0; i < domainSize; i++)
            {
                for (int j = 0; j < instructions.Count; j++)
                {
                    var instruction = instructions[j];
                    if (i + inslens[j] < domainSize && dump.Copy(i, inslens[j]).Matches(instruction))
                    {
                        int pad = 0;
                        Debug.Assert(inslens[j] <= 8);
                        while (pad < (8 - inslens[j]))
                        {
                            hitAddresses.Add(domainSize - 1);
                            pad++;
                        }
                        for (int k = 0; k < inslens[j]; k++)
                        {
                            hitAddresses.Add(i + k);
                        }
                        break;
                    }
                }
            }

            VmdPrototype vmdPrototype = new VmdPrototype();
            vmdPrototype.GenDomain = mi.Name;
            vmdPrototype.BigEndian = mi.BigEndian;
            vmdPrototype.AddSingles = hitAddresses;
            vmdPrototype.WordSize = mi.WordSize;
            vmdPrototype.VmdName = $"{mi.Name} - Potential Variable Width Code";
            vmdPrototype.PointerSpacer = 1;
            if (hitAddresses.Count != 0)
            {
                LocalNetCoreRouter.Route(Ep.RTC_SIDE, Commands.MAKEAVMD, (object)vmdPrototype, true);
            }

        }
    }
    public enum AsmLanguage
    {
        X86, M68K, MOS65816
    }

    public static class MathExtensions
    {
        public static bool Matches(this byte[] self, ORegex<byte> regex)
        {
            return regex.IsMatch(self);
        }

        public static byte[] Copy(this byte[] self, int offset, int size)
        {
            byte[] ret = new byte[size];
            Buffer.BlockCopy(self, offset, ret, 0, size);
            return ret;
        }

        public static bool Fits(this byte self, string binary)
        {
            long template = 0;
            long reserved = 0;
            //Fill in the fields
            binary = binary.ToUpper().Replace("0B", "");
            int curLeftShift = 0; //Additional variable to maintain my sanity
            for (int j = binary.Length - 1; j >= 0; j--)
            {
                if (binary[j] == '?') { } //Wildcard
                else if (binary[j] == '#') { } //Passthrough
                else //Constant
                {
                    //line[j] is guaranteed to be '1' or '0' here
                    template |= ((long)binary[j] - 48) << curLeftShift; //Convert char to long and shift
                    reserved |= 1L << curLeftShift; //Also add to reserved mask
                }

                curLeftShift++;
            }
            return (byte)template == (self & (byte)reserved);
        }
    }

    public class AsmSpec
    {
        public List<ORegex<byte>> Instructions { get; set; }
        public List<int> InstructionLengths { get; set; }

        public static Dictionary<AsmLanguage, AsmSpec> GSpecs = new Dictionary<AsmLanguage, AsmSpec>();

        public static bool IsX86JccShort(byte x)
        {
            if (x == 0x74) return true; // jump short if equal
            if (x == 0x7f) return true; // jump short if greater
            if (x == 0x7D) return true; // jump short if greater or equal
            if (x == 0x7c) return true; // jump short if less
            if (x == 0x7e) return true; // jump short if less or equal
            if (x == 0x75) return true; // jump short if not equal
            if (x == 0x74) return true; // jump short if zero
            return false;
        }

        static AsmSpec()
        {
            GSpecs[AsmLanguage.X86] = new AsmSpec()
            {
                Instructions = new List<ORegex<byte>>()
                {
                    // core x86 isa
                    //new ORegex<byte>("{0}{1}", x => IsX86JccShort(x), x=> true), // jcc short
                    new ORegex<byte>("{0}{1}{2}{3}{4}{5}", x => Is0F(x), x => IsX86JccNearRel32(x), x => true,x => true,x => true,x => true), // jcc near (rel32)
                    new ORegex<byte>("{0}{1}", x => x == 1 || x == 3, x => /*(x & 0b11000000) != 0*/ x.Fits("0b11??????")), // 32-bit add register to register
                    new ORegex<byte>("{0}{1}{2}{3}{4}{5}", x=> x == 0x81 || x ==0x83, x => /*(x & 0b11010000) != 0*/x.Fits("0b11000???"), x => true,x => true,x => true,x => true), // 32-bit add immediate to register
                    new ORegex<byte>("{0}{1}", x => x == 0xff, x => x.Fits("0b11100???")), // jump to register
                    new ORegex<byte>("{0}{1}", x => x.Fits("0b100010??"), x => x.Fits("0b11??????")), // mov register to register
                    new ORegex<byte>("{0}{1}{2}{3}{4}{5}", x=> x.Fits("0b1100011?"), x=> x.Fits("0b11000???"), x => true,x => true,x => true,x => true ), // mov immediate to register

                    //// mmx extension
                    //new ORegex<byte>("{0}{1}{3}", x=> Is0F(x), x=>x.Fits("0b011?1110"), x=>x.Fits("0b11??????")), // movd reg to/from mmxreg
                },
                InstructionLengths = new List<int>()
                {
                    6,
                    2,
                    6,
                    2,
                    2,
                    6
                }
            };
            GSpecs[AsmLanguage.M68K] = new AsmSpec()
            {
                Instructions = new List<ORegex<byte>>()
                {
                    new ORegex<byte>("{0}{1}{2}{3}", x => x.Fits("0b01000110"), x => x.Fits("0b11??????"), x => true, x=> true), // move immediate into status register?
                    new ORegex<byte>("{0}{1}{2}{3}", x => x.Fits("0b00?????0"), x => x.Fits("0b01??????"), x => true, x=> true), // movea
                    new ORegex<byte>("{0}{1}{2}{3}", x => x.Fits("0b1100????"), x => x.Fits("0b11111?00"), x => true, x=> true), // mul
                },
                InstructionLengths = new List<int>()
                {
                    4, 4, 4
                }
            };
            GSpecs[AsmLanguage.MOS65816] = new AsmSpec()
            {
                Instructions = new List<ORegex<byte>>()
                {

                //new ORegex<byte>("{0}{1}{2}", x=> x == 0x4C || x == 0x6C || x == 0x7c || x== 0xdc, x => true,x => true), //jmp (3 bytes)
                //new ORegex<byte>("{0]{1}{2}{3}", x=> x == 0x5c, x => true,x => true,x => true), // jmp (4 bytes)
                new ORegex<byte>("{0}{1}{2}", x => x == 0x20, x => true,x => true), // jsr (3 bytes)
                new ORegex<byte>("{0}{1}{2}{3}", x => x == 0x22, x => true,x => true,x => true), // jsr (4 bytes)
                new ORegex<byte>("{0}{1}", x => x== 0xa1 || x == 0xa3 || x == 0xa5 || x == 0xa7 || x== 0xb1 || x == 0xb3 || x == 0xb5 || x == 0xb7, x => true), // lda (2 bytes)
                new ORegex<byte>("{0}{1}{2}", x => x == 0x90 || x == 0xB0 || x == 0xF0, x => true, x => true), // bcc/bcs/beq (2 bytes)
                new ORegex<byte>("{0}{1}", x => x == 0xC1 || x == 0xc3 || x == 0xc5 || x == 0xc7|| x == 0xD1 || x == 0xd2 || x == 0xd3 || x == 0xd5 || x == 0xd7, x => true), // cmp (2 bytes)

                },
                InstructionLengths = new List<int>()
                {
                    /*3, 4,*/ 3, 4, 2, 3, 2
                }
            };
        }

        private static bool IsX86JccNearRel32(byte x)
        {
            if (x == 0x84) return true; // JE/JZ
            if (x == 0x8F) return true; // JG
            if (x == 0x8D) return true; // JGE
            if (x == 0x8C) return true; // JL
            if (x == 0x8E) return true; // JLE
            if (x == 0x85) return true; // JNE
            return false;
        }

        private static bool Is0F(byte x)
        {
            return x == 0x0F;
        }
    }
}
