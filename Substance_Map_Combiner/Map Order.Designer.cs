namespace Substance_Map_Combiner
{
    partial class Map_Order
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
            this.LBX_MapOrder = new System.Windows.Forms.ListBox();
            this.B_Accept = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.CB_MapTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LBX_MapOrder
            // 
            this.LBX_MapOrder.AllowDrop = true;
            this.LBX_MapOrder.FormattingEnabled = true;
            this.LBX_MapOrder.Location = new System.Drawing.Point(12, 5);
            this.LBX_MapOrder.Name = "LBX_MapOrder";
            this.LBX_MapOrder.Size = new System.Drawing.Size(402, 394);
            this.LBX_MapOrder.TabIndex = 0;
            this.LBX_MapOrder.DragDrop += new System.Windows.Forms.DragEventHandler(this.LBX_MapOrder_DragDrop);
            this.LBX_MapOrder.DragOver += new System.Windows.Forms.DragEventHandler(this.LBX_MapOrder_DragOver);
            this.LBX_MapOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LBX_MapOrder_MouseDown);
            // 
            // B_Accept
            // 
            this.B_Accept.Location = new System.Drawing.Point(12, 415);
            this.B_Accept.Name = "B_Accept";
            this.B_Accept.Size = new System.Drawing.Size(75, 23);
            this.B_Accept.TabIndex = 1;
            this.B_Accept.Text = "Accept";
            this.B_Accept.UseVisualStyleBackColor = true;
            this.B_Accept.Click += new System.EventHandler(this.B_Accept_Click);
            // 
            // B_Cancel
            // 
            this.B_Cancel.Location = new System.Drawing.Point(93, 415);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(75, 23);
            this.B_Cancel.TabIndex = 2;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // CB_MapTypes
            // 
            this.CB_MapTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_MapTypes.FormattingEnabled = true;
            this.CB_MapTypes.Location = new System.Drawing.Point(293, 415);
            this.CB_MapTypes.Name = "CB_MapTypes";
            this.CB_MapTypes.Size = new System.Drawing.Size(121, 21);
            this.CB_MapTypes.TabIndex = 3;
            this.CB_MapTypes.SelectedIndexChanged += new System.EventHandler(this.CB_MapTypes_SelectedIndexChanged);
            // 
            // Map_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.CB_MapTypes);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.B_Accept);
            this.Controls.Add(this.LBX_MapOrder);
            this.Name = "Map_Order";
            this.Text = "Map_Order";
            this.Load += new System.EventHandler(this.Map_Order_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBX_MapOrder;
        private System.Windows.Forms.Button B_Accept;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.ComboBox CB_MapTypes;
    }
}