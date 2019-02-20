namespace Substance_Map_Combiner
{
    partial class Preferences_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.CmBx_SuffixType = new System.Windows.Forms.ComboBox();
            this.TxtBx_Suffixes = new System.Windows.Forms.TextBox();
            this.TxtBx_OutputSuffix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Reset = new System.Windows.Forms.Button();
            this.B_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmBx_SuffixType
            // 
            this.CmBx_SuffixType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBx_SuffixType.FormattingEnabled = true;
            this.CmBx_SuffixType.Items.AddRange(new object[] {
            "Base Color",
            "Roughness",
            "Metallic",
            "AO",
            "IOR",
            "Normal",
            "NormalDX",
            "Height",
            "Emissive",
            "Reflection",
            "Specular",
            "Glossiness"});
            this.CmBx_SuffixType.Location = new System.Drawing.Point(388, 16);
            this.CmBx_SuffixType.Name = "CmBx_SuffixType";
            this.CmBx_SuffixType.Size = new System.Drawing.Size(121, 21);
            this.CmBx_SuffixType.TabIndex = 0;
            this.CmBx_SuffixType.SelectedIndexChanged += new System.EventHandler(this.CmBx_SuffixType_SelectedIndexChanged);
            // 
            // TxtBx_Suffixes
            // 
            this.TxtBx_Suffixes.Location = new System.Drawing.Point(86, 16);
            this.TxtBx_Suffixes.Name = "TxtBx_Suffixes";
            this.TxtBx_Suffixes.Size = new System.Drawing.Size(296, 20);
            this.TxtBx_Suffixes.TabIndex = 1;
            this.TxtBx_Suffixes.TextChanged += new System.EventHandler(this.TxtBx_Suffixes_TextChanged);
            // 
            // TxtBx_OutputSuffix
            // 
            this.TxtBx_OutputSuffix.Location = new System.Drawing.Point(86, 38);
            this.TxtBx_OutputSuffix.Name = "TxtBx_OutputSuffix";
            this.TxtBx_OutputSuffix.Size = new System.Drawing.Size(118, 20);
            this.TxtBx_OutputSuffix.TabIndex = 2;
            this.TxtBx_OutputSuffix.TextChanged += new System.EventHandler(this.TxtBx_OutputSuffix_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Map Suffixes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Suffix";
            // 
            // B_Reset
            // 
            this.B_Reset.Location = new System.Drawing.Point(96, 121);
            this.B_Reset.Name = "B_Reset";
            this.B_Reset.Size = new System.Drawing.Size(75, 23);
            this.B_Reset.TabIndex = 6;
            this.B_Reset.Text = "Reset";
            this.B_Reset.UseVisualStyleBackColor = true;
            this.B_Reset.Click += new System.EventHandler(this.B_Reset_Click);
            // 
            // B_Close
            // 
            this.B_Close.Location = new System.Drawing.Point(15, 121);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(75, 23);
            this.B_Close.TabIndex = 7;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // Preferences_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 181);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBx_OutputSuffix);
            this.Controls.Add(this.TxtBx_Suffixes);
            this.Controls.Add(this.CmBx_SuffixType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Preferences_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preferences_Window_FormClosing);
            this.Load += new System.EventHandler(this.Preferences_Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmBx_SuffixType;
        private System.Windows.Forms.TextBox TxtBx_Suffixes;
        private System.Windows.Forms.TextBox TxtBx_OutputSuffix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Reset;
        private System.Windows.Forms.Button B_Close;
    }
}