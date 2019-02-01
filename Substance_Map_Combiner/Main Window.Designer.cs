namespace Substance_Map_Combiner
{
    partial class MainWindow
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
            this.B_Source_Folder_Button = new System.Windows.Forms.Button();
            this.B_Destination_Folder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Source_Folder_Button
            // 
            this.B_Source_Folder_Button.Location = new System.Drawing.Point(37, 24);
            this.B_Source_Folder_Button.Name = "B_Source_Folder_Button";
            this.B_Source_Folder_Button.Size = new System.Drawing.Size(102, 22);
            this.B_Source_Folder_Button.TabIndex = 0;
            this.B_Source_Folder_Button.Text = "Source Folder";
            this.B_Source_Folder_Button.UseVisualStyleBackColor = true;
            this.B_Source_Folder_Button.Click += new System.EventHandler(this.B_Source_Folder_Button_Click);
            // 
            // B_Destination_Folder
            // 
            this.B_Destination_Folder.Location = new System.Drawing.Point(686, 24);
            this.B_Destination_Folder.Name = "B_Destination_Folder";
            this.B_Destination_Folder.Size = new System.Drawing.Size(102, 22);
            this.B_Destination_Folder.TabIndex = 1;
            this.B_Destination_Folder.Text = "Destination Folder";
            this.B_Destination_Folder.UseVisualStyleBackColor = true;
            this.B_Destination_Folder.Click += new System.EventHandler(this.B_Destination_Folder_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_Destination_Folder);
            this.Controls.Add(this.B_Source_Folder_Button);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Source_Folder_Button;
        private System.Windows.Forms.Button B_Destination_Folder;
    }
}

