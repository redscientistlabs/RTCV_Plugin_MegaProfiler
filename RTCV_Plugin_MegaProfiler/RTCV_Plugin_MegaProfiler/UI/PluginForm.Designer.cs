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
            this.btnLoadDomains = new System.Windows.Forms.Button();
            this.cbSelectedMemoryDomain = new System.Windows.Forms.ComboBox();
            this.cbAsmSpec = new System.Windows.Forms.ComboBox();
            this.lbAsmSpec = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadDomains
            // 
            this.btnLoadDomains.BackColor = System.Drawing.Color.Gray;
            this.btnLoadDomains.FlatAppearance.BorderSize = 0;
            this.btnLoadDomains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDomains.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnLoadDomains.ForeColor = System.Drawing.Color.White;
            this.btnLoadDomains.Location = new System.Drawing.Point(12, 12);
            this.btnLoadDomains.Name = "btnLoadDomains";
            this.btnLoadDomains.Size = new System.Drawing.Size(80, 48);
            this.btnLoadDomains.TabIndex = 128;
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
            this.cbSelectedMemoryDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSelectedMemoryDomain.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbSelectedMemoryDomain.ForeColor = System.Drawing.Color.White;
            this.cbSelectedMemoryDomain.FormattingEnabled = true;
            this.cbSelectedMemoryDomain.Location = new System.Drawing.Point(12, 65);
            this.cbSelectedMemoryDomain.Name = "cbSelectedMemoryDomain";
            this.cbSelectedMemoryDomain.Size = new System.Drawing.Size(169, 21);
            this.cbSelectedMemoryDomain.TabIndex = 127;
            this.cbSelectedMemoryDomain.Tag = "color:dark1";
            // 
            // comboBox1
            // 
            this.cbAsmSpec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbAsmSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsmSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAsmSpec.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbAsmSpec.ForeColor = System.Drawing.Color.White;
            this.cbAsmSpec.FormattingEnabled = true;
            this.cbAsmSpec.Items.AddRange(new object[] {
            "X86"});
            this.cbAsmSpec.Location = new System.Drawing.Point(647, 12);
            this.cbAsmSpec.Name = "comboBox1";
            this.cbAsmSpec.Size = new System.Drawing.Size(169, 21);
            this.cbAsmSpec.TabIndex = 127;
            this.cbAsmSpec.Tag = "color:dark1";
            // 
            // lbAsmSpec
            // 
            this.lbAsmSpec.AutoSize = true;
            this.lbAsmSpec.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbAsmSpec.ForeColor = System.Drawing.Color.White;
            this.lbAsmSpec.Location = new System.Drawing.Point(533, 20);
            this.lbAsmSpec.Name = "lbAsmSpec";
            this.lbAsmSpec.Size = new System.Drawing.Size(108, 13);
            this.lbAsmSpec.TabIndex = 129;
            this.lbAsmSpec.Text = "Assembly Language";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Gray;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(184, 91);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(80, 48);
            this.btnGenerate.TabIndex = 128;
            this.btnGenerate.TabStop = false;
            this.btnGenerate.Tag = "color:light1";
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(828, 535);
            this.Controls.Add(this.lbAsmSpec);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnLoadDomains);
            this.Controls.Add(this.cbAsmSpec);
            this.Controls.Add(this.cbSelectedMemoryDomain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PluginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "color:dark1";
            this.Text = "Plugin Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnLoadDomains;
        public System.Windows.Forms.ComboBox cbSelectedMemoryDomain;
        public System.Windows.Forms.ComboBox cbAsmSpec;
        public System.Windows.Forms.Label lbAsmSpec;
        private System.Windows.Forms.Button btnGenerate;
    }
}
