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
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Source_Folder_Button
            // 
            this.B_Source_Folder_Button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.B_Source_Folder_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_Source_Folder_Button.Location = new System.Drawing.Point(37, 24);
            this.B_Source_Folder_Button.Name = "B_Source_Folder_Button";
            this.B_Source_Folder_Button.Size = new System.Drawing.Size(102, 22);
            this.B_Source_Folder_Button.TabIndex = 0;
            this.B_Source_Folder_Button.Text = "Source Folder";
            this.B_Source_Folder_Button.UseVisualStyleBackColor = false;
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
            // B_Combine_Images
            // 
            this.B_Combine_Images.Location = new System.Drawing.Point(343, 24);
            this.B_Combine_Images.Name = "B_Combine_Images";
            this.B_Combine_Images.Size = new System.Drawing.Size(102, 22);
            this.B_Combine_Images.TabIndex = 2;
            this.B_Combine_Images.Text = "Combine";
            this.B_Combine_Images.UseVisualStyleBackColor = true;
            this.B_Combine_Images.Click += new System.EventHandler(this.B_Combine_Images_Click);
            // 
            // flowLayoutPanel1
            // 
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(37, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(691, 213);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // B_BaseColorPicker
            // 
            this.B_BaseColorPicker.Location = new System.Drawing.Point(3, 3);
            this.B_BaseColorPicker.Name = "B_BaseColorPicker";
            this.B_BaseColorPicker.Size = new System.Drawing.Size(75, 23);
            this.B_BaseColorPicker.TabIndex = 13;
            this.B_BaseColorPicker.Tag = "BaseColor";
            this.B_BaseColorPicker.UseVisualStyleBackColor = true;
            // 
            // CB_BaseColor
            // 
            this.CB_BaseColor.AutoSize = true;
            this.CB_BaseColor.BackColor = System.Drawing.Color.White;
            this.CB_BaseColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_BaseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_BaseColor.Location = new System.Drawing.Point(3, 32);
            this.CB_BaseColor.Name = "CB_BaseColor";
            this.CB_BaseColor.Size = new System.Drawing.Size(85, 17);
            this.CB_BaseColor.TabIndex = 0;
            this.CB_BaseColor.Tag = "BaseColor";
            this.CB_BaseColor.Text = "Base Color";
            this.CB_BaseColor.UseVisualStyleBackColor = false;
            // 
            // B_RoughnessPicker
            // 
            this.B_RoughnessPicker.Location = new System.Drawing.Point(3, 55);
            this.B_RoughnessPicker.Name = "B_RoughnessPicker";
            this.B_RoughnessPicker.Size = new System.Drawing.Size(75, 23);
            this.B_RoughnessPicker.TabIndex = 14;
            this.B_RoughnessPicker.Tag = "Base_Color";
            this.B_RoughnessPicker.UseVisualStyleBackColor = true;
            // 
            // CB_Roughness
            // 
            this.CB_Roughness.AutoSize = true;
            this.CB_Roughness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Roughness.Location = new System.Drawing.Point(3, 84);
            this.CB_Roughness.Name = "CB_Roughness";
            this.CB_Roughness.Size = new System.Drawing.Size(89, 17);
            this.CB_Roughness.TabIndex = 1;
            this.CB_Roughness.Tag = "Roughness";
            this.CB_Roughness.Text = "Roughness";
            this.CB_Roughness.UseVisualStyleBackColor = true;
            // 
            // B_MetallicPicker
            // 
            this.B_MetallicPicker.Location = new System.Drawing.Point(3, 107);
            this.B_MetallicPicker.Name = "B_MetallicPicker";
            this.B_MetallicPicker.Size = new System.Drawing.Size(75, 23);
            this.B_MetallicPicker.TabIndex = 17;
            this.B_MetallicPicker.Tag = "Metallic";
            this.B_MetallicPicker.UseVisualStyleBackColor = true;
            // 
            // CB_Metallic
            // 
            this.CB_Metallic.AutoSize = true;
            this.CB_Metallic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Metallic.Location = new System.Drawing.Point(3, 136);
            this.CB_Metallic.Name = "CB_Metallic";
            this.CB_Metallic.Size = new System.Drawing.Size(70, 17);
            this.CB_Metallic.TabIndex = 2;
            this.CB_Metallic.Tag = "Metallic";
            this.CB_Metallic.Text = "Metallic";
            this.CB_Metallic.UseVisualStyleBackColor = true;
            // 
            // B_AmbientOcclusionPicker
            // 
            this.B_AmbientOcclusionPicker.Location = new System.Drawing.Point(3, 159);
            this.B_AmbientOcclusionPicker.Name = "B_AmbientOcclusionPicker";
            this.B_AmbientOcclusionPicker.Size = new System.Drawing.Size(75, 23);
            this.B_AmbientOcclusionPicker.TabIndex = 15;
            this.B_AmbientOcclusionPicker.Tag = "AO";
            this.B_AmbientOcclusionPicker.UseVisualStyleBackColor = true;
            // 
            // CB_Ambient_Occlusion
            // 
            this.CB_Ambient_Occlusion.AutoSize = true;
            this.CB_Ambient_Occlusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Ambient_Occlusion.Location = new System.Drawing.Point(3, 188);
            this.CB_Ambient_Occlusion.Name = "CB_Ambient_Occlusion";
            this.CB_Ambient_Occlusion.Size = new System.Drawing.Size(43, 17);
            this.CB_Ambient_Occlusion.TabIndex = 3;
            this.CB_Ambient_Occlusion.Tag = "AO";
            this.CB_Ambient_Occlusion.Text = "AO";
            this.CB_Ambient_Occlusion.UseVisualStyleBackColor = true;
            // 
            // B_IORPicker
            // 
            this.B_IORPicker.Location = new System.Drawing.Point(98, 3);
            this.B_IORPicker.Name = "B_IORPicker";
            this.B_IORPicker.Size = new System.Drawing.Size(75, 23);
            this.B_IORPicker.TabIndex = 16;
            this.B_IORPicker.Tag = "IOR";
            this.B_IORPicker.UseVisualStyleBackColor = true;
            // 
            // CB_IOR
            // 
            this.CB_IOR.AutoSize = true;
            this.CB_IOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_IOR.Location = new System.Drawing.Point(98, 32);
            this.CB_IOR.Name = "CB_IOR";
            this.CB_IOR.Size = new System.Drawing.Size(48, 17);
            this.CB_IOR.TabIndex = 4;
            this.CB_IOR.Tag = "IOR";
            this.CB_IOR.Text = "IOR";
            this.CB_IOR.UseVisualStyleBackColor = true;
            // 
            // B_NormalPicker
            // 
            this.B_NormalPicker.Location = new System.Drawing.Point(98, 55);
            this.B_NormalPicker.Name = "B_NormalPicker";
            this.B_NormalPicker.Size = new System.Drawing.Size(75, 23);
            this.B_NormalPicker.TabIndex = 18;
            this.B_NormalPicker.Tag = "Normal";
            this.B_NormalPicker.UseVisualStyleBackColor = true;
            // 
            // CB_Normal
            // 
            this.CB_Normal.AutoSize = true;
            this.CB_Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Normal.Location = new System.Drawing.Point(98, 84);
            this.CB_Normal.Name = "CB_Normal";
            this.CB_Normal.Size = new System.Drawing.Size(65, 17);
            this.CB_Normal.TabIndex = 5;
            this.CB_Normal.Tag = "Normal";
            this.CB_Normal.Text = "Normal";
            this.CB_Normal.UseVisualStyleBackColor = true;
            // 
            // B_NormalDXPicker
            // 
            this.B_NormalDXPicker.Location = new System.Drawing.Point(98, 107);
            this.B_NormalDXPicker.Name = "B_NormalDXPicker";
            this.B_NormalDXPicker.Size = new System.Drawing.Size(75, 23);
            this.B_NormalDXPicker.TabIndex = 19;
            this.B_NormalDXPicker.Tag = "NormalDX";
            this.B_NormalDXPicker.UseVisualStyleBackColor = true;
            // 
            // CB_NormalDX
            // 
            this.CB_NormalDX.AutoSize = true;
            this.CB_NormalDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_NormalDX.Location = new System.Drawing.Point(98, 136);
            this.CB_NormalDX.Name = "CB_NormalDX";
            this.CB_NormalDX.Size = new System.Drawing.Size(94, 17);
            this.CB_NormalDX.TabIndex = 6;
            this.CB_NormalDX.Tag = "NormalDX";
            this.CB_NormalDX.Text = "Normal (DX)";
            this.CB_NormalDX.UseVisualStyleBackColor = true;
            // 
            // B_HeightPicker
            // 
            this.B_HeightPicker.Location = new System.Drawing.Point(98, 159);
            this.B_HeightPicker.Name = "B_HeightPicker";
            this.B_HeightPicker.Size = new System.Drawing.Size(75, 23);
            this.B_HeightPicker.TabIndex = 20;
            this.B_HeightPicker.Tag = "Height";
            this.B_HeightPicker.UseVisualStyleBackColor = true;
            // 
            // CB_Height
            // 
            this.CB_Height.AutoSize = true;
            this.CB_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Height.Location = new System.Drawing.Point(98, 188);
            this.CB_Height.Name = "CB_Height";
            this.CB_Height.Size = new System.Drawing.Size(63, 17);
            this.CB_Height.TabIndex = 7;
            this.CB_Height.Tag = "Height";
            this.CB_Height.Text = "Height";
            this.CB_Height.UseVisualStyleBackColor = true;
            // 
            // B_EmissivePicker
            // 
            this.B_EmissivePicker.Location = new System.Drawing.Point(198, 3);
            this.B_EmissivePicker.Name = "B_EmissivePicker";
            this.B_EmissivePicker.Size = new System.Drawing.Size(75, 23);
            this.B_EmissivePicker.TabIndex = 21;
            this.B_EmissivePicker.Tag = "Emissive";
            this.B_EmissivePicker.UseVisualStyleBackColor = true;
            // 
            // CB_Emissive
            // 
            this.CB_Emissive.AutoSize = true;
            this.CB_Emissive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Emissive.Location = new System.Drawing.Point(198, 32);
            this.CB_Emissive.Name = "CB_Emissive";
            this.CB_Emissive.Size = new System.Drawing.Size(75, 17);
            this.CB_Emissive.TabIndex = 8;
            this.CB_Emissive.Tag = "Emissive";
            this.CB_Emissive.Text = "Emissive";
            this.CB_Emissive.UseVisualStyleBackColor = true;
            // 
            // B_DiffusePicker
            // 
            this.B_DiffusePicker.Location = new System.Drawing.Point(198, 55);
            this.B_DiffusePicker.Name = "B_DiffusePicker";
            this.B_DiffusePicker.Size = new System.Drawing.Size(75, 23);
            this.B_DiffusePicker.TabIndex = 22;
            this.B_DiffusePicker.Tag = "Diffuse";
            this.B_DiffusePicker.UseVisualStyleBackColor = true;
            // 
            // CB_Diffuse
            // 
            this.CB_Diffuse.AutoSize = true;
            this.CB_Diffuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Diffuse.Location = new System.Drawing.Point(198, 84);
            this.CB_Diffuse.Name = "CB_Diffuse";
            this.CB_Diffuse.Size = new System.Drawing.Size(66, 17);
            this.CB_Diffuse.TabIndex = 10;
            this.CB_Diffuse.Tag = "Diffuse";
            this.CB_Diffuse.Text = "Diffuse";
            this.CB_Diffuse.UseVisualStyleBackColor = true;
            // 
            // B_SpecularPicker
            // 
            this.B_SpecularPicker.Location = new System.Drawing.Point(198, 107);
            this.B_SpecularPicker.Name = "B_SpecularPicker";
            this.B_SpecularPicker.Size = new System.Drawing.Size(75, 23);
            this.B_SpecularPicker.TabIndex = 23;
            this.B_SpecularPicker.Tag = "Specular";
            this.B_SpecularPicker.UseVisualStyleBackColor = true;
            // 
            // CB_Specular
            // 
            this.CB_Specular.AutoSize = true;
            this.CB_Specular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Specular.Location = new System.Drawing.Point(198, 136);
            this.CB_Specular.Name = "CB_Specular";
            this.CB_Specular.Size = new System.Drawing.Size(76, 17);
            this.CB_Specular.TabIndex = 11;
            this.CB_Specular.Tag = "Specular";
            this.CB_Specular.Text = "Specular";
            this.CB_Specular.UseVisualStyleBackColor = true;
            // 
            // B_GlossinessPicker
            // 
            this.B_GlossinessPicker.Location = new System.Drawing.Point(198, 159);
            this.B_GlossinessPicker.Name = "B_GlossinessPicker";
            this.B_GlossinessPicker.Size = new System.Drawing.Size(75, 23);
            this.B_GlossinessPicker.TabIndex = 24;
            this.B_GlossinessPicker.Tag = "Glossiness";
            this.B_GlossinessPicker.UseVisualStyleBackColor = true;
            // 
            // CB_Glossiness
            // 
            this.CB_Glossiness.AutoSize = true;
            this.CB_Glossiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Glossiness.Location = new System.Drawing.Point(198, 188);
            this.CB_Glossiness.Name = "CB_Glossiness";
            this.CB_Glossiness.Size = new System.Drawing.Size(86, 17);
            this.CB_Glossiness.TabIndex = 12;
            this.CB_Glossiness.Tag = "Glossiness";
            this.CB_Glossiness.Text = "Glossiness";
            this.CB_Glossiness.UseVisualStyleBackColor = true;
            // 
            // B_ReflectionPicker
            // 
            this.B_ReflectionPicker.Location = new System.Drawing.Point(290, 3);
            this.B_ReflectionPicker.Name = "B_ReflectionPicker";
            this.B_ReflectionPicker.Size = new System.Drawing.Size(75, 23);
            this.B_ReflectionPicker.TabIndex = 25;
            this.B_ReflectionPicker.Tag = "Reflection";
            this.B_ReflectionPicker.UseVisualStyleBackColor = true;
            // 
            // CB_Reflection
            // 
            this.CB_Reflection.AutoSize = true;
            this.CB_Reflection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Reflection.Location = new System.Drawing.Point(290, 32);
            this.CB_Reflection.Name = "CB_Reflection";
            this.CB_Reflection.Size = new System.Drawing.Size(84, 17);
            this.CB_Reflection.TabIndex = 9;
            this.CB_Reflection.Tag = "Reflection";
            this.CB_Reflection.Text = "Reflection";
            this.CB_Reflection.UseVisualStyleBackColor = true;
            // 
            // TxtBx_FileName
            // 
            this.TxtBx_FileName.Location = new System.Drawing.Point(447, 326);
            this.TxtBx_FileName.Name = "TxtBx_FileName";
            this.TxtBx_FileName.Size = new System.Drawing.Size(100, 20);
            this.TxtBx_FileName.TabIndex = 4;
            this.TxtBx_FileName.TextChanged += new System.EventHandler(this.TxtBx_FileName_TextChanged);
            // 
            // CB_FileType
            // 
            this.CB_FileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_FileType.FormattingEnabled = true;
            this.CB_FileType.Items.AddRange(new object[] {
            ".jpeg",
            ".jpg",
            ".png",
            ".tga",
            ".tiff"});
            this.CB_FileType.Location = new System.Drawing.Point(553, 325);
            this.CB_FileType.Name = "CB_FileType";
            this.CB_FileType.Size = new System.Drawing.Size(121, 21);
            this.CB_FileType.TabIndex = 5;
            this.CB_FileType.SelectedIndexChanged += new System.EventHandler(this.CB_FileType_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Preferences});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // TSMI_Preferences
            // 
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "Main Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

