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
            this.CmBx_SuffixType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.CmBx_SuffixType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBx_SuffixType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBx_SuffixType.ForeColor = System.Drawing.SystemColors.Control;
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
            this.CmBx_SuffixType.Location = new System.Drawing.Point(402, 16);
            this.CmBx_SuffixType.Name = "CmBx_SuffixType";
            this.CmBx_SuffixType.Size = new System.Drawing.Size(121, 20);
            this.CmBx_SuffixType.TabIndex = 0;
            this.CmBx_SuffixType.SelectedIndexChanged += new System.EventHandler(this.CmBx_SuffixType_SelectedIndexChanged);
            // 
            // TxtBx_Suffixes
            // 
            this.TxtBx_Suffixes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.TxtBx_Suffixes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBx_Suffixes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Suffixes.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtBx_Suffixes.Location = new System.Drawing.Point(100, 15);
            this.TxtBx_Suffixes.Name = "TxtBx_Suffixes";
            this.TxtBx_Suffixes.Size = new System.Drawing.Size(296, 21);
            this.TxtBx_Suffixes.TabIndex = 1;
            this.TxtBx_Suffixes.TextChanged += new System.EventHandler(this.TxtBx_Suffixes_TextChanged);
            // 
            // TxtBx_OutputSuffix
            // 
            this.TxtBx_OutputSuffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.TxtBx_OutputSuffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBx_OutputSuffix.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_OutputSuffix.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtBx_OutputSuffix.Location = new System.Drawing.Point(100, 42);
            this.TxtBx_OutputSuffix.Name = "TxtBx_OutputSuffix";
            this.TxtBx_OutputSuffix.Size = new System.Drawing.Size(118, 21);
            this.TxtBx_OutputSuffix.TabIndex = 2;
            this.TxtBx_OutputSuffix.TextChanged += new System.EventHandler(this.TxtBx_OutputSuffix_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Map Suffixes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Suffix";
            // 
            // B_Reset
            // 
            this.B_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.B_Reset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Reset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Reset.ForeColor = System.Drawing.SystemColors.Control;
            this.B_Reset.Location = new System.Drawing.Point(96, 121);
            this.B_Reset.Name = "B_Reset";
            this.B_Reset.Size = new System.Drawing.Size(75, 23);
            this.B_Reset.TabIndex = 6;
            this.B_Reset.Text = "Reset";
            this.B_Reset.UseVisualStyleBackColor = false;
            this.B_Reset.Click += new System.EventHandler(this.B_Reset_Click);
            // 
            // B_Close
            // 
            this.B_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.B_Close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.B_Close.Location = new System.Drawing.Point(15, 121);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(75, 23);
            this.B_Close.TabIndex = 7;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = false;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // Preferences_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(534, 156);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBx_OutputSuffix);
            this.Controls.Add(this.TxtBx_Suffixes);
            this.Controls.Add(this.CmBx_SuffixType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Preferences_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preferences_Window_FormClosing);
            this.Load += new System.EventHandler(this.Preferences_Window_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Preferences_Window_KeyDown);
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