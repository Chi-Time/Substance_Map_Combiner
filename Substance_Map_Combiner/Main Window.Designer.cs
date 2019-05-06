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
            this.B_Combine_Images = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_BaseColorPicker = new System.Windows.Forms.Button();
            this.CB_BaseColor = new System.Windows.Forms.CheckBox();
            this.B_RoughnessPicker = new System.Windows.Forms.Button();
            this.CB_Roughness = new System.Windows.Forms.CheckBox();
            this.B_MetallicPicker = new System.Windows.Forms.Button();
            this.CB_Metallic = new System.Windows.Forms.CheckBox();
            this.B_AmbientOcclusionPicker = new System.Windows.Forms.Button();
            this.CB_Ambient_Occlusion = new System.Windows.Forms.CheckBox();
            this.B_IORPicker = new System.Windows.Forms.Button();
            this.CB_IOR = new System.Windows.Forms.CheckBox();
            this.B_NormalPicker = new System.Windows.Forms.Button();
            this.CB_Normal = new System.Windows.Forms.CheckBox();
            this.B_NormalDXPicker = new System.Windows.Forms.Button();
            this.CB_NormalDX = new System.Windows.Forms.CheckBox();
            this.B_HeightPicker = new System.Windows.Forms.Button();
            this.CB_Height = new System.Windows.Forms.CheckBox();
            this.B_EmissivePicker = new System.Windows.Forms.Button();
            this.CB_Emissive = new System.Windows.Forms.CheckBox();
            this.B_DiffusePicker = new System.Windows.Forms.Button();
            this.CB_Diffuse = new System.Windows.Forms.CheckBox();
            this.B_SpecularPicker = new System.Windows.Forms.Button();
            this.CB_Specular = new System.Windows.Forms.CheckBox();
            this.B_GlossinessPicker = new System.Windows.Forms.Button();
            this.CB_Glossiness = new System.Windows.Forms.CheckBox();
            this.B_ReflectionPicker = new System.Windows.Forms.Button();
            this.CB_Reflection = new System.Windows.Forms.CheckBox();
            this.TxtBx_FileName = new System.Windows.Forms.TextBox();
            this.CB_FileType = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Preferences = new System.Windows.Forms.ToolStripMenuItem();
            this.L_Log = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B_MapOrder = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FLP_Console = new System.Windows.Forms.FlowLayoutPanel();
            this.Lbl_ConsoleText = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.FLP_Console.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Source_Folder_Button
            // 
            this.B_Source_Folder_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.B_Source_Folder_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B_Source_Folder_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_Source_Folder_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Source_Folder_Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Source_Folder_Button.ForeColor = System.Drawing.SystemColors.Control;
            this.B_Source_Folder_Button.Location = new System.Drawing.Point(12, 243);
            this.B_Source_Folder_Button.Name = "B_Source_Folder_Button";
            this.B_Source_Folder_Button.Size = new System.Drawing.Size(140, 37);
            this.B_Source_Folder_Button.TabIndex = 0;
            this.B_Source_Folder_Button.Text = "Source Folder";
            this.B_Source_Folder_Button.UseVisualStyleBackColor = false;
            this.B_Source_Folder_Button.Click += new System.EventHandler(this.B_Source_Folder_Button_Click);
            // 
            // B_Destination_Folder
            // 
            this.B_Destination_Folder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.B_Destination_Folder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B_Destination_Folder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_Destination_Folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Destination_Folder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Destination_Folder.ForeColor = System.Drawing.SystemColors.Control;
            this.B_Destination_Folder.Location = new System.Drawing.Point(158, 243);
            this.B_Destination_Folder.Name = "B_Destination_Folder";
            this.B_Destination_Folder.Size = new System.Drawing.Size(140, 37);
            this.B_Destination_Folder.TabIndex = 1;
            this.B_Destination_Folder.Text = "Destination Folder";
            this.B_Destination_Folder.UseVisualStyleBackColor = false;
            this.B_Destination_Folder.Click += new System.EventHandler(this.B_Destination_Folder_Click);
            // 
            // B_Combine_Images
            // 
            this.B_Combine_Images.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.B_Combine_Images.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B_Combine_Images.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_Combine_Images.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Combine_Images.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Combine_Images.ForeColor = System.Drawing.SystemColors.Control;
            this.B_Combine_Images.Location = new System.Drawing.Point(450, 243);
            this.B_Combine_Images.Name = "B_Combine_Images";
            this.B_Combine_Images.Size = new System.Drawing.Size(140, 37);
            this.B_Combine_Images.TabIndex = 2;
            this.B_Combine_Images.Text = "Combine";
            this.B_Combine_Images.UseVisualStyleBackColor = false;
            this.B_Combine_Images.Click += new System.EventHandler(this.B_Combine_Images_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.flowLayoutPanel1.Controls.Add(this.B_BaseColorPicker);
            this.flowLayoutPanel1.Controls.Add(this.CB_BaseColor);
            this.flowLayoutPanel1.Controls.Add(this.B_RoughnessPicker);
            this.flowLayoutPanel1.Controls.Add(this.CB_Roughness);
            this.flowLayoutPanel1.Controls.Add(this.B_MetallicPicker);
            this.flowLayoutPanel1.Controls.Add(this.CB_Metallic);
            this.flowLayoutPanel1.Controls.Add(this.B_AmbientOcclusionPicker);
            this.flowLayoutPanel1.Controls.Add(this.CB_Ambient_Occlusion);
            this.flowLayoutPanel1.Controls.Add(this.B_IORPicker);
            this.flowLayoutPanel1.Controls.Add(this.CB_IOR);
            this.flowLayoutPanel1.Controls.Add(this.B_NormalPicker);
            this.flowLayoutPanel1.Controls.Add(this.CB_Normal);
            this.flowLayoutPanel1.Controls.Add(this.B_NormalDXPicker);
            this.flowLayoutPanel1.Controls.Add(this.CB_NormalDX);
            this.flowLayoutPanel1.Controls.Add(this.B_HeightPicker);
            this.flowLayoutPanel1.Controls.Add(this.CB_Height);
            this.flowLayoutPanel1.Controls.Add(this.B_EmissivePicker);
            this.flowLayoutPanel1.Controls.Add(this.CB_Emissive);
            this.flowLayoutPanel1.Controls.Add(this.B_DiffusePicker);
            this.flowLayoutPanel1.Controls.Add(this.CB_Diffuse);
            this.flowLayoutPanel1.Controls.Add(this.B_SpecularPicker);
            this.flowLayoutPanel1.Controls.Add(this.CB_Specular);
            this.flowLayoutPanel1.Controls.Add(this.B_GlossinessPicker);
            this.flowLayoutPanel1.Controls.Add(this.CB_Glossiness);
            this.flowLayoutPanel1.Controls.Add(this.B_ReflectionPicker);
            this.flowLayoutPanel1.Controls.Add(this.CB_Reflection);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(589, 162);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // B_BaseColorPicker
            // 
            this.B_BaseColorPicker.BackColor = System.Drawing.Color.White;
            this.B_BaseColorPicker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_BaseColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_BaseColorPicker.Location = new System.Drawing.Point(3, 3);
            this.B_BaseColorPicker.Name = "B_BaseColorPicker";
            this.B_BaseColorPicker.Size = new System.Drawing.Size(95, 23);
            this.B_BaseColorPicker.TabIndex = 13;
            this.B_BaseColorPicker.Tag = "BaseColor";
            this.B_BaseColorPicker.UseVisualStyleBackColor = false;
            // 
            // CB_BaseColor
            // 
            this.CB_BaseColor.AutoSize = true;
            this.CB_BaseColor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_BaseColor.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_BaseColor.Location = new System.Drawing.Point(3, 32);
            this.CB_BaseColor.Name = "CB_BaseColor";
            this.CB_BaseColor.Size = new System.Drawing.Size(95, 16);
            this.CB_BaseColor.TabIndex = 0;
            this.CB_BaseColor.Tag = "BaseColor";
            this.CB_BaseColor.Text = "Base Color";
            this.CB_BaseColor.UseVisualStyleBackColor = false;
            // 
            // B_RoughnessPicker
            // 
            this.B_RoughnessPicker.BackColor = System.Drawing.Color.White;
            this.B_RoughnessPicker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_RoughnessPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_RoughnessPicker.Location = new System.Drawing.Point(3, 54);
            this.B_RoughnessPicker.Name = "B_RoughnessPicker";
            this.B_RoughnessPicker.Size = new System.Drawing.Size(95, 23);
            this.B_RoughnessPicker.TabIndex = 14;
            this.B_RoughnessPicker.Tag = "Base_Color";
            this.B_RoughnessPicker.UseVisualStyleBackColor = false;
            // 
            // CB_Roughness
            // 
            this.CB_Roughness.AutoSize = true;
            this.CB_Roughness.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Roughness.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Roughness.Location = new System.Drawing.Point(3, 83);
            this.CB_Roughness.Name = "CB_Roughness";
            this.CB_Roughness.Size = new System.Drawing.Size(95, 16);
            this.CB_Roughness.TabIndex = 1;
            this.CB_Roughness.Tag = "Roughness";
            this.CB_Roughness.Text = "Roughness";
            this.CB_Roughness.UseVisualStyleBackColor = true;
            // 
            // B_MetallicPicker
            // 
            this.B_MetallicPicker.BackColor = System.Drawing.Color.White;
            this.B_MetallicPicker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_MetallicPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_MetallicPicker.Location = new System.Drawing.Point(3, 105);
            this.B_MetallicPicker.Name = "B_MetallicPicker";
            this.B_MetallicPicker.Size = new System.Drawing.Size(95, 23);
            this.B_MetallicPicker.TabIndex = 17;
            this.B_MetallicPicker.Tag = "Metallic";
            this.B_MetallicPicker.UseVisualStyleBackColor = false;
            // 
            // CB_Metallic
            // 
            this.CB_Metallic.AutoSize = true;
            this.CB_Metallic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Metallic.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Metallic.Location = new System.Drawing.Point(3, 134);
            this.CB_Metallic.Name = "CB_Metallic";
            this.CB_Metallic.Size = new System.Drawing.Size(75, 16);
            this.CB_Metallic.TabIndex = 2;
            this.CB_Metallic.Tag = "Metallic";
            this.CB_Metallic.Text = "Metallic";
            this.CB_Metallic.UseVisualStyleBackColor = true;
            // 
            // B_AmbientOcclusionPicker
            // 
            this.B_AmbientOcclusionPicker.BackColor = System.Drawing.Color.White;
            this.B_AmbientOcclusionPicker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_AmbientOcclusionPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_AmbientOcclusionPicker.Location = new System.Drawing.Point(104, 3);
            this.B_AmbientOcclusionPicker.Name = "B_AmbientOcclusionPicker";
            this.B_AmbientOcclusionPicker.Size = new System.Drawing.Size(95, 23);
            this.B_AmbientOcclusionPicker.TabIndex = 15;
            this.B_AmbientOcclusionPicker.Tag = "AO";
            this.B_AmbientOcclusionPicker.UseVisualStyleBackColor = false;
            // 
            // CB_Ambient_Occlusion
            // 
            this.CB_Ambient_Occlusion.AutoSize = true;
            this.CB_Ambient_Occlusion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Ambient_Occlusion.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Ambient_Occlusion.Location = new System.Drawing.Point(104, 32);
            this.CB_Ambient_Occlusion.Name = "CB_Ambient_Occlusion";
            this.CB_Ambient_Occlusion.Size = new System.Drawing.Size(43, 16);
            this.CB_Ambient_Occlusion.TabIndex = 3;
            this.CB_Ambient_Occlusion.Tag = "AO";
            this.CB_Ambient_Occlusion.Text = "AO";
            this.CB_Ambient_Occlusion.UseVisualStyleBackColor = true;
            // 
            // B_IORPicker
            // 
            this.B_IORPicker.BackColor = System.Drawing.Color.White;
            this.B_IORPicker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_IORPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_IORPicker.Location = new System.Drawing.Point(104, 54);
            this.B_IORPicker.Name = "B_IORPicker";
            this.B_IORPicker.Size = new System.Drawing.Size(95, 23);
            this.B_IORPicker.TabIndex = 16;
            this.B_IORPicker.Tag = "IOR";
            this.B_IORPicker.UseVisualStyleBackColor = false;
            // 
            // CB_IOR
            // 
            this.CB_IOR.AutoSize = true;
            this.CB_IOR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_IOR.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_IOR.Location = new System.Drawing.Point(104, 83);
            this.CB_IOR.Name = "CB_IOR";
            this.CB_IOR.Size = new System.Drawing.Size(47, 16);
            this.CB_IOR.TabIndex = 4;
            this.CB_IOR.Tag = "IOR";
            this.CB_IOR.Text = "IOR";
            this.CB_IOR.UseVisualStyleBackColor = true;
            // 
            // B_NormalPicker
            // 
            this.B_NormalPicker.BackColor = System.Drawing.Color.White;
            this.B_NormalPicker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_NormalPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_NormalPicker.Location = new System.Drawing.Point(104, 105);
            this.B_NormalPicker.Name = "B_NormalPicker";
            this.B_NormalPicker.Size = new System.Drawing.Size(95, 23);
            this.B_NormalPicker.TabIndex = 18;
            this.B_NormalPicker.Tag = "Normal";
            this.B_NormalPicker.UseVisualStyleBackColor = false;
            // 
            // CB_Normal
            // 
            this.CB_Normal.AutoSize = true;
            this.CB_Normal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Normal.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Normal.Location = new System.Drawing.Point(104, 134);
            this.CB_Normal.Name = "CB_Normal";
            this.CB_Normal.Size = new System.Drawing.Size(70, 16);
            this.CB_Normal.TabIndex = 5;
            this.CB_Normal.Tag = "Normal";
            this.CB_Normal.Text = "Normal";
            this.CB_Normal.UseVisualStyleBackColor = true;
            // 
            // B_NormalDXPicker
            // 
            this.B_NormalDXPicker.BackColor = System.Drawing.Color.White;
            this.B_NormalDXPicker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_NormalDXPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_NormalDXPicker.Location = new System.Drawing.Point(205, 3);
            this.B_NormalDXPicker.Name = "B_NormalDXPicker";
            this.B_NormalDXPicker.Size = new System.Drawing.Size(95, 23);
            this.B_NormalDXPicker.TabIndex = 19;
            this.B_NormalDXPicker.Tag = "Normal_DirectX";
            this.B_NormalDXPicker.UseVisualStyleBackColor = false;
            // 
            // CB_NormalDX
            // 
            this.CB_NormalDX.AutoSize = true;
            this.CB_NormalDX.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_NormalDX.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_NormalDX.Location = new System.Drawing.Point(205, 32);
            this.CB_NormalDX.Name = "CB_NormalDX";
            this.CB_NormalDX.Size = new System.Drawing.Size(101, 16);
            this.CB_NormalDX.TabIndex = 6;
            this.CB_NormalDX.Tag = "Normal_DirectX";
            this.CB_NormalDX.Text = "Normal (DX)";
            this.CB_NormalDX.UseVisualStyleBackColor = true;
            // 
            // B_HeightPicker
            // 
            this.B_HeightPicker.BackColor = System.Drawing.Color.White;
            this.B_HeightPicker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_HeightPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_HeightPicker.Location = new System.Drawing.Point(205, 54);
            this.B_HeightPicker.Name = "B_HeightPicker";
            this.B_HeightPicker.Size = new System.Drawing.Size(95, 23);
            this.B_HeightPicker.TabIndex = 20;
            this.B_HeightPicker.Tag = "Height";
            this.B_HeightPicker.UseVisualStyleBackColor = false;
            // 
            // CB_Height
            // 
            this.CB_Height.AutoSize = true;
            this.CB_Height.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Height.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Height.Location = new System.Drawing.Point(205, 83);
            this.CB_Height.Name = "CB_Height";
            this.CB_Height.Size = new System.Drawing.Size(66, 16);
            this.CB_Height.TabIndex = 7;
            this.CB_Height.Tag = "Height";
            this.CB_Height.Text = "Height";
            this.CB_Height.UseVisualStyleBackColor = true;
            // 
            // B_EmissivePicker
            // 
            this.B_EmissivePicker.BackColor = System.Drawing.Color.White;
            this.B_EmissivePicker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_EmissivePicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_EmissivePicker.Location = new System.Drawing.Point(205, 105);
            this.B_EmissivePicker.Name = "B_EmissivePicker";
            this.B_EmissivePicker.Size = new System.Drawing.Size(95, 23);
            this.B_EmissivePicker.TabIndex = 21;
            this.B_EmissivePicker.Tag = "Emissive";
            this.B_EmissivePicker.UseVisualStyleBackColor = false;
            // 
            // CB_Emissive
            // 
            this.CB_Emissive.AutoSize = true;
            this.CB_Emissive.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Emissive.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Emissive.Location = new System.Drawing.Point(205, 134);
            this.CB_Emissive.Name = "CB_Emissive";
            this.CB_Emissive.Size = new System.Drawing.Size(80, 16);
            this.CB_Emissive.TabIndex = 8;
            this.CB_Emissive.Tag = "Emissive";
            this.CB_Emissive.Text = "Emissive";
            this.CB_Emissive.UseVisualStyleBackColor = true;
            // 
            // B_DiffusePicker
            // 
            this.B_DiffusePicker.BackColor = System.Drawing.Color.White;
            this.B_DiffusePicker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_DiffusePicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_DiffusePicker.Location = new System.Drawing.Point(312, 3);
            this.B_DiffusePicker.Name = "B_DiffusePicker";
            this.B_DiffusePicker.Size = new System.Drawing.Size(95, 23);
            this.B_DiffusePicker.TabIndex = 22;
            this.B_DiffusePicker.Tag = "Diffuse";
            this.B_DiffusePicker.UseVisualStyleBackColor = false;
            // 
            // CB_Diffuse
            // 
            this.CB_Diffuse.AutoSize = true;
            this.CB_Diffuse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Diffuse.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Diffuse.Location = new System.Drawing.Point(312, 32);
            this.CB_Diffuse.Name = "CB_Diffuse";
            this.CB_Diffuse.Size = new System.Drawing.Size(70, 16);
            this.CB_Diffuse.TabIndex = 10;
            this.CB_Diffuse.Tag = "Diffuse";
            this.CB_Diffuse.Text = "Diffuse";
            this.CB_Diffuse.UseVisualStyleBackColor = true;
            // 
            // B_SpecularPicker
            // 
            this.B_SpecularPicker.BackColor = System.Drawing.Color.White;
            this.B_SpecularPicker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_SpecularPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_SpecularPicker.Location = new System.Drawing.Point(312, 54);
            this.B_SpecularPicker.Name = "B_SpecularPicker";
            this.B_SpecularPicker.Size = new System.Drawing.Size(95, 23);
            this.B_SpecularPicker.TabIndex = 23;
            this.B_SpecularPicker.Tag = "Specular";
            this.B_SpecularPicker.UseVisualStyleBackColor = false;
            // 
            // CB_Specular
            // 
            this.CB_Specular.AutoSize = true;
            this.CB_Specular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Specular.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Specular.Location = new System.Drawing.Point(312, 83);
            this.CB_Specular.Name = "CB_Specular";
            this.CB_Specular.Size = new System.Drawing.Size(82, 16);
            this.CB_Specular.TabIndex = 11;
            this.CB_Specular.Tag = "Specular";
            this.CB_Specular.Text = "Specular";
            this.CB_Specular.UseVisualStyleBackColor = true;
            // 
            // B_GlossinessPicker
            // 
            this.B_GlossinessPicker.BackColor = System.Drawing.Color.White;
            this.B_GlossinessPicker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_GlossinessPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_GlossinessPicker.Location = new System.Drawing.Point(312, 105);
            this.B_GlossinessPicker.Name = "B_GlossinessPicker";
            this.B_GlossinessPicker.Size = new System.Drawing.Size(95, 23);
            this.B_GlossinessPicker.TabIndex = 24;
            this.B_GlossinessPicker.Tag = "Glossiness";
            this.B_GlossinessPicker.UseVisualStyleBackColor = false;
            // 
            // CB_Glossiness
            // 
            this.CB_Glossiness.AutoSize = true;
            this.CB_Glossiness.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Glossiness.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Glossiness.Location = new System.Drawing.Point(312, 134);
            this.CB_Glossiness.Name = "CB_Glossiness";
            this.CB_Glossiness.Size = new System.Drawing.Size(94, 16);
            this.CB_Glossiness.TabIndex = 12;
            this.CB_Glossiness.Tag = "Glossiness";
            this.CB_Glossiness.Text = "Glossiness";
            this.CB_Glossiness.UseVisualStyleBackColor = true;
            // 
            // B_ReflectionPicker
            // 
            this.B_ReflectionPicker.BackColor = System.Drawing.Color.White;
            this.B_ReflectionPicker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_ReflectionPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ReflectionPicker.Location = new System.Drawing.Point(413, 3);
            this.B_ReflectionPicker.Name = "B_ReflectionPicker";
            this.B_ReflectionPicker.Size = new System.Drawing.Size(95, 23);
            this.B_ReflectionPicker.TabIndex = 25;
            this.B_ReflectionPicker.Tag = "Reflection";
            this.B_ReflectionPicker.UseVisualStyleBackColor = false;
            // 
            // CB_Reflection
            // 
            this.CB_Reflection.AutoSize = true;
            this.CB_Reflection.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Reflection.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Reflection.Location = new System.Drawing.Point(413, 32);
            this.CB_Reflection.Name = "CB_Reflection";
            this.CB_Reflection.Size = new System.Drawing.Size(91, 16);
            this.CB_Reflection.TabIndex = 9;
            this.CB_Reflection.Tag = "Reflection";
            this.CB_Reflection.Text = "Reflection";
            this.CB_Reflection.UseVisualStyleBackColor = true;
            // 
            // TxtBx_FileName
            // 
            this.TxtBx_FileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.TxtBx_FileName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_FileName.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtBx_FileName.Location = new System.Drawing.Point(304, 216);
            this.TxtBx_FileName.Name = "TxtBx_FileName";
            this.TxtBx_FileName.Size = new System.Drawing.Size(140, 21);
            this.TxtBx_FileName.TabIndex = 4;
            this.TxtBx_FileName.TextChanged += new System.EventHandler(this.TxtBx_FileName_TextChanged);
            // 
            // CB_FileType
            // 
            this.CB_FileType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.CB_FileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_FileType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_FileType.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_FileType.FormattingEnabled = true;
            this.CB_FileType.Items.AddRange(new object[] {
            ".jpeg",
            ".jpg",
            ".png",
            ".tga",
            ".tiff"});
            this.CB_FileType.Location = new System.Drawing.Point(450, 216);
            this.CB_FileType.Name = "CB_FileType";
            this.CB_FileType.Size = new System.Drawing.Size(121, 20);
            this.CB_FileType.TabIndex = 5;
            this.CB_FileType.SelectedIndexChanged += new System.EventHandler(this.CB_FileType_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Preferences,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // TSMI_Preferences
            // 
            this.TSMI_Preferences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.TSMI_Preferences.ForeColor = System.Drawing.SystemColors.Control;
            this.TSMI_Preferences.Name = "TSMI_Preferences";
            this.TSMI_Preferences.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.TSMI_Preferences.Size = new System.Drawing.Size(193, 22);
            this.TSMI_Preferences.Text = "Preferences";
            this.TSMI_Preferences.Click += new System.EventHandler(this.TSMI_Preferences_Click);
            // 
            // L_Log
            // 
            this.L_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Log.AutoSize = true;
            this.L_Log.Location = new System.Drawing.Point(37, 325);
            this.L_Log.Name = "L_Log";
            this.L_Log.Size = new System.Drawing.Size(0, 13);
            this.L_Log.TabIndex = 0;
            this.L_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(205, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Output Name:";
            // 
            // B_MapOrder
            // 
            this.B_MapOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.B_MapOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B_MapOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.B_MapOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_MapOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_MapOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.B_MapOrder.Location = new System.Drawing.Point(304, 243);
            this.B_MapOrder.Name = "B_MapOrder";
            this.B_MapOrder.Size = new System.Drawing.Size(140, 37);
            this.B_MapOrder.TabIndex = 8;
            this.B_MapOrder.Text = "Map Order";
            this.B_MapOrder.UseVisualStyleBackColor = false;
            this.B_MapOrder.Click += new System.EventHandler(this.B_MapOrder_Click);
            // 
            // FLP_Console
            // 
            this.FLP_Console.AutoScroll = true;
            this.FLP_Console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.FLP_Console.Controls.Add(this.Lbl_ConsoleText);
            this.FLP_Console.Location = new System.Drawing.Point(15, 295);
            this.FLP_Console.Name = "FLP_Console";
            this.FLP_Console.Size = new System.Drawing.Size(575, 135);
            this.FLP_Console.TabIndex = 10;
            // 
            // Lbl_ConsoleText
            // 
            this.Lbl_ConsoleText.AutoSize = true;
            this.Lbl_ConsoleText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConsoleText.ForeColor = System.Drawing.Color.GreenYellow;
            this.Lbl_ConsoleText.Location = new System.Drawing.Point(15, 15);
            this.Lbl_ConsoleText.Margin = new System.Windows.Forms.Padding(15, 15, 3, 0);
            this.Lbl_ConsoleText.Name = "Lbl_ConsoleText";
            this.Lbl_ConsoleText.Size = new System.Drawing.Size(0, 16);
            this.Lbl_ConsoleText.TabIndex = 0;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.clearToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(614, 442);
            this.Controls.Add(this.FLP_Console);
            this.Controls.Add(this.B_MapOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Log);
            this.Controls.Add(this.CB_FileType);
            this.Controls.Add(this.TxtBx_FileName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.B_Combine_Images);
            this.Controls.Add(this.B_Destination_Folder);
            this.Controls.Add(this.B_Source_Folder_Button);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Substance Map Combiner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FLP_Console.ResumeLayout(false);
            this.FLP_Console.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Source_Folder_Button;
        private System.Windows.Forms.Button B_Destination_Folder;
        private System.Windows.Forms.Button B_Combine_Images;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox CB_BaseColor;
        private System.Windows.Forms.CheckBox CB_Roughness;
        private System.Windows.Forms.CheckBox CB_Metallic;
        private System.Windows.Forms.CheckBox CB_Ambient_Occlusion;
        private System.Windows.Forms.CheckBox CB_IOR;
        private System.Windows.Forms.CheckBox CB_Normal;
        private System.Windows.Forms.CheckBox CB_NormalDX;
        private System.Windows.Forms.CheckBox CB_Height;
        private System.Windows.Forms.CheckBox CB_Emissive;
        private System.Windows.Forms.CheckBox CB_Reflection;
        private System.Windows.Forms.CheckBox CB_Diffuse;
        private System.Windows.Forms.CheckBox CB_Specular;
        private System.Windows.Forms.CheckBox CB_Glossiness;
        private System.Windows.Forms.TextBox TxtBx_FileName;
        private System.Windows.Forms.ComboBox CB_FileType;
        private System.Windows.Forms.Button B_BaseColorPicker;
        private System.Windows.Forms.Button B_RoughnessPicker;
        private System.Windows.Forms.Button B_MetallicPicker;
        private System.Windows.Forms.Button B_AmbientOcclusionPicker;
        private System.Windows.Forms.Button B_IORPicker;
        private System.Windows.Forms.Button B_NormalPicker;
        private System.Windows.Forms.Button B_NormalDXPicker;
        private System.Windows.Forms.Button B_HeightPicker;
        private System.Windows.Forms.Button B_EmissivePicker;
        private System.Windows.Forms.Button B_DiffusePicker;
        private System.Windows.Forms.Button B_SpecularPicker;
        private System.Windows.Forms.Button B_GlossinessPicker;
        private System.Windows.Forms.Button B_ReflectionPicker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Preferences;
        private System.Windows.Forms.Label L_Log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_MapOrder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel FLP_Console;
        private System.Windows.Forms.Label Lbl_ConsoleText;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

