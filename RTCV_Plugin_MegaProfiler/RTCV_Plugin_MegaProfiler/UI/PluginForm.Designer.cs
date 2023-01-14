using System;
using System.IO;
using System.Windows.Forms;


namespace PLUGIN_MEGAPROFILER.UI
{

    partial class PluginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginForm));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEndianTypeValue = new System.Windows.Forms.Label();
            this.lbWordSizeValue = new System.Windows.Forms.Label();
            this.lbDomainSizeValue = new System.Windows.Forms.Label();
            this.lbEndianTypeLabel = new System.Windows.Forms.Label();
            this.lbWordSizeLabel = new System.Windows.Forms.Label();
            this.lbDomainSizeLabel = new System.Windows.Forms.Label();
            this.btnLoadDomains = new System.Windows.Forms.Button();
            this.cbSelectedMemoryDomain = new System.Windows.Forms.ComboBox();
            this.cbAsmSpec = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbAsmSpec = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(8, 271);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(505, 32);
            this.btnGenerate.TabIndex = 128;
            this.btnGenerate.TabStop = false;
            this.btnGenerate.Tag = "color:dark3";
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(205, 28);
            this.version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(16, 17);
            this.version.TabIndex = 131;
            this.version.Text = "v";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 41);
            this.label1.TabIndex = 130;
            this.label1.Text = "Mega Profiler";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lbEndianTypeValue);
            this.panel1.Controls.Add(this.lbWordSizeValue);
            this.panel1.Controls.Add(this.lbDomainSizeValue);
            this.panel1.Controls.Add(this.lbEndianTypeLabel);
            this.panel1.Controls.Add(this.lbWordSizeLabel);
            this.panel1.Controls.Add(this.lbDomainSizeLabel);
            this.panel1.Controls.Add(this.btnLoadDomains);
            this.panel1.Controls.Add(this.cbSelectedMemoryDomain);
            this.panel1.Controls.Add(this.cbAsmSpec);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lbAsmSpec);
            this.panel1.Location = new System.Drawing.Point(20, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 185);
            this.panel1.TabIndex = 132;
            this.panel1.Tag = "color:dark2";
            // 
            // lbEndianTypeValue
            // 
            this.lbEndianTypeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEndianTypeValue.AutoSize = true;
            this.lbEndianTypeValue.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbEndianTypeValue.ForeColor = System.Drawing.Color.White;
            this.lbEndianTypeValue.Location = new System.Drawing.Point(403, 71);
            this.lbEndianTypeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEndianTypeValue.Name = "lbEndianTypeValue";
            this.lbEndianTypeValue.Size = new System.Drawing.Size(49, 19);
            this.lbEndianTypeValue.TabIndex = 158;
            this.lbEndianTypeValue.Text = "#####";
            // 
            // lbWordSizeValue
            // 
            this.lbWordSizeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWordSizeValue.AutoSize = true;
            this.lbWordSizeValue.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbWordSizeValue.ForeColor = System.Drawing.Color.White;
            this.lbWordSizeValue.Location = new System.Drawing.Point(403, 49);
            this.lbWordSizeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWordSizeValue.Name = "lbWordSizeValue";
            this.lbWordSizeValue.Size = new System.Drawing.Size(49, 19);
            this.lbWordSizeValue.TabIndex = 157;
            this.lbWordSizeValue.Text = "#####";
            // 
            // lbDomainSizeValue
            // 
            this.lbDomainSizeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDomainSizeValue.AutoSize = true;
            this.lbDomainSizeValue.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbDomainSizeValue.ForeColor = System.Drawing.Color.White;
            this.lbDomainSizeValue.Location = new System.Drawing.Point(403, 27);
            this.lbDomainSizeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDomainSizeValue.Name = "lbDomainSizeValue";
            this.lbDomainSizeValue.Size = new System.Drawing.Size(49, 19);
            this.lbDomainSizeValue.TabIndex = 156;
            this.lbDomainSizeValue.Text = "#####";
            // 
            // lbEndianTypeLabel
            // 
            this.lbEndianTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEndianTypeLabel.AutoSize = true;
            this.lbEndianTypeLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbEndianTypeLabel.ForeColor = System.Drawing.Color.White;
            this.lbEndianTypeLabel.Location = new System.Drawing.Point(299, 71);
            this.lbEndianTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEndianTypeLabel.Name = "lbEndianTypeLabel";
            this.lbEndianTypeLabel.Size = new System.Drawing.Size(85, 19);
            this.lbEndianTypeLabel.TabIndex = 155;
            this.lbEndianTypeLabel.Text = "Endian Type:";
            // 
            // lbWordSizeLabel
            // 
            this.lbWordSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWordSizeLabel.AutoSize = true;
            this.lbWordSizeLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbWordSizeLabel.ForeColor = System.Drawing.Color.White;
            this.lbWordSizeLabel.Location = new System.Drawing.Point(298, 49);
            this.lbWordSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWordSizeLabel.Name = "lbWordSizeLabel";
            this.lbWordSizeLabel.Size = new System.Drawing.Size(72, 19);
            this.lbWordSizeLabel.TabIndex = 154;
            this.lbWordSizeLabel.Text = "Word Size:";
            // 
            // lbDomainSizeLabel
            // 
            this.lbDomainSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDomainSizeLabel.AutoSize = true;
            this.lbDomainSizeLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbDomainSizeLabel.ForeColor = System.Drawing.Color.White;
            this.lbDomainSizeLabel.Location = new System.Drawing.Point(298, 27);
            this.lbDomainSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDomainSizeLabel.Name = "lbDomainSizeLabel";
            this.lbDomainSizeLabel.Size = new System.Drawing.Size(87, 19);
            this.lbDomainSizeLabel.TabIndex = 153;
            this.lbDomainSizeLabel.Text = "Domain Size:";
            // 
            // btnLoadDomains
            // 
            this.btnLoadDomains.BackColor = System.Drawing.Color.Gray;
            this.btnLoadDomains.FlatAppearance.BorderSize = 0;
            this.btnLoadDomains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDomains.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnLoadDomains.ForeColor = System.Drawing.Color.White;
            this.btnLoadDomains.Location = new System.Drawing.Point(25, 28);
            this.btnLoadDomains.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadDomains.Name = "btnLoadDomains";
            this.btnLoadDomains.Size = new System.Drawing.Size(107, 58);
            this.btnLoadDomains.TabIndex = 17;
            this.btnLoadDomains.TabStop = false;
            this.btnLoadDomains.Tag = "color:light1";
            this.btnLoadDomains.Text = "Load Domains";
            this.btnLoadDomains.UseVisualStyleBackColor = false;
            this.btnLoadDomains.Click += new System.EventHandler(this.btnLoadDomains_Click);
            // 
            // cbSelectedMemoryDomain
            // 
            this.cbSelectedMemoryDomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbSelectedMemoryDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectedMemoryDomain.DropDownWidth = 172;
            this.cbSelectedMemoryDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSelectedMemoryDomain.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbSelectedMemoryDomain.ForeColor = System.Drawing.Color.White;
            this.cbSelectedMemoryDomain.FormattingEnabled = true;
            this.cbSelectedMemoryDomain.Location = new System.Drawing.Point(140, 54);
            this.cbSelectedMemoryDomain.Margin = new System.Windows.Forms.Padding(4);
            this.cbSelectedMemoryDomain.Name = "cbSelectedMemoryDomain";
            this.cbSelectedMemoryDomain.Size = new System.Drawing.Size(136, 29);
            this.cbSelectedMemoryDomain.TabIndex = 16;
            this.cbSelectedMemoryDomain.Tag = "color:dark1";
            this.cbSelectedMemoryDomain.SelectedIndexChanged += new System.EventHandler(this.HandleSelectedMemoryDomainChange);
            // 
            // cbAsmSpec
            // 
            this.cbAsmSpec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbAsmSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsmSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAsmSpec.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbAsmSpec.ForeColor = System.Drawing.Color.White;
            this.cbAsmSpec.FormattingEnabled = true;
            this.cbAsmSpec.Items.AddRange(new object[] {
            "X86"});
            this.cbAsmSpec.Location = new System.Drawing.Point(25, 132);
            this.cbAsmSpec.Margin = new System.Windows.Forms.Padding(4);
            this.cbAsmSpec.Name = "cbAsmSpec";
            this.cbAsmSpec.Size = new System.Drawing.Size(251, 25);
            this.cbAsmSpec.TabIndex = 127;
            this.cbAsmSpec.Tag = "color:dark1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(136, 28);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 19);
            this.label17.TabIndex = 117;
            this.label17.Text = "Memory Domain";
            // 
            // lbAsmSpec
            // 
            this.lbAsmSpec.AutoSize = true;
            this.lbAsmSpec.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbAsmSpec.ForeColor = System.Drawing.Color.White;
            this.lbAsmSpec.Location = new System.Drawing.Point(21, 107);
            this.lbAsmSpec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAsmSpec.Name = "lbAsmSpec";
            this.lbAsmSpec.Size = new System.Drawing.Size(131, 19);
            this.lbAsmSpec.TabIndex = 129;
            this.lbAsmSpec.Text = "Assembly Language";
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(520, 308);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.version);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(520, 308);
            this.Name = "PluginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "color:dark1";
            this.Text = "Plugin Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private Label version;
        private Label label1;
        private Panel panel1;
        private Button btnLoadDomains;
        public ComboBox cbSelectedMemoryDomain;
        public ComboBox cbAsmSpec;
        private Label label17;
        public Label lbAsmSpec;
        public Label lbEndianTypeValue;
        public Label lbWordSizeValue;
        public Label lbDomainSizeValue;
        public Label lbEndianTypeLabel;
        public Label lbWordSizeLabel;
        public Label lbDomainSizeLabel;
    }
}
