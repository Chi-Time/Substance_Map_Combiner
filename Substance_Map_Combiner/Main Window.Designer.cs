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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CB_Roughness = new System.Windows.Forms.CheckBox();
            this.CB_Metallic = new System.Windows.Forms.CheckBox();
            this.CB_Ambient_Occlusion = new System.Windows.Forms.CheckBox();
            this.CB_IOR = new System.Windows.Forms.CheckBox();
            this.CB_Normal = new System.Windows.Forms.CheckBox();
            this.CB_NormalDX = new System.Windows.Forms.CheckBox();
            this.CB_Height = new System.Windows.Forms.CheckBox();
            this.CB_Emissive = new System.Windows.Forms.CheckBox();
            this.CB_Reflection = new System.Windows.Forms.CheckBox();
            this.CB_Diffuse = new System.Windows.Forms.CheckBox();
            this.CB_Specular = new System.Windows.Forms.CheckBox();
            this.CB_Glossiness = new System.Windows.Forms.CheckBox();
            this.TxtBx_FileName = new System.Windows.Forms.TextBox();
            this.CB_FileType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.B_BaseColorPicker = new System.Windows.Forms.Button();
            this.B_RoughnessPicker = new System.Windows.Forms.Button();
            this.B_AmbientOcclusionPicker = new System.Windows.Forms.Button();
            this.B_IORPicker = new System.Windows.Forms.Button();
            this.B_MetallicPicker = new System.Windows.Forms.Button();
            this.B_NormalPicker = new System.Windows.Forms.Button();
            this.B_NormalDXPicker = new System.Windows.Forms.Button();
            this.B_HeightPicker = new System.Windows.Forms.Button();
            this.B_EmissivePicker = new System.Windows.Forms.Button();
            this.B_DiffusePicker = new System.Windows.Forms.Button();
            this.B_SpecularPicker = new System.Windows.Forms.Button();
            this.B_GlossinessPicker = new System.Windows.Forms.Button();
            this.B_ReflectionPicker = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Base Color";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CB_Roughness
            // 
            this.CB_Roughness.AutoSize = true;
            this.CB_Roughness.Location = new System.Drawing.Point(3, 84);
            this.CB_Roughness.Name = "CB_Roughness";
            this.CB_Roughness.Size = new System.Drawing.Size(80, 17);
            this.CB_Roughness.TabIndex = 1;
            this.CB_Roughness.Text = "Roughness";
            this.CB_Roughness.UseVisualStyleBackColor = true;
            this.CB_Roughness.CheckedChanged += new System.EventHandler(this.CB_Roughness_CheckedChanged);
            // 
            // CB_Metallic
            // 
            this.CB_Metallic.AutoSize = true;
            this.CB_Metallic.Location = new System.Drawing.Point(3, 136);
            this.CB_Metallic.Name = "CB_Metallic";
            this.CB_Metallic.Size = new System.Drawing.Size(62, 17);
            this.CB_Metallic.TabIndex = 2;
            this.CB_Metallic.Text = "Metallic";
            this.CB_Metallic.UseVisualStyleBackColor = true;
            this.CB_Metallic.CheckedChanged += new System.EventHandler(this.CB_Metallic_CheckedChanged);
            // 
            // CB_Ambient_Occlusion
            // 
            this.CB_Ambient_Occlusion.AutoSize = true;
            this.CB_Ambient_Occlusion.Location = new System.Drawing.Point(3, 188);
            this.CB_Ambient_Occlusion.Name = "CB_Ambient_Occlusion";
            this.CB_Ambient_Occlusion.Size = new System.Drawing.Size(114, 17);
            this.CB_Ambient_Occlusion.TabIndex = 3;
            this.CB_Ambient_Occlusion.Text = "Ambient Occlusion";
            this.CB_Ambient_Occlusion.UseVisualStyleBackColor = true;
            this.CB_Ambient_Occlusion.CheckedChanged += new System.EventHandler(this.CB_Ambient_Occlusion_CheckedChanged);
            // 
            // CB_IOR
            // 
            this.CB_IOR.AutoSize = true;
            this.CB_IOR.Location = new System.Drawing.Point(123, 32);
            this.CB_IOR.Name = "CB_IOR";
            this.CB_IOR.Size = new System.Drawing.Size(45, 17);
            this.CB_IOR.TabIndex = 4;
            this.CB_IOR.Text = "IOR";
            this.CB_IOR.UseVisualStyleBackColor = true;
            this.CB_IOR.CheckedChanged += new System.EventHandler(this.CB_IOR_CheckedChanged);
            // 
            // CB_Normal
            // 
            this.CB_Normal.AutoSize = true;
            this.CB_Normal.Location = new System.Drawing.Point(123, 84);
            this.CB_Normal.Name = "CB_Normal";
            this.CB_Normal.Size = new System.Drawing.Size(59, 17);
            this.CB_Normal.TabIndex = 5;
            this.CB_Normal.Text = "Normal";
            this.CB_Normal.UseVisualStyleBackColor = true;
            this.CB_Normal.CheckedChanged += new System.EventHandler(this.CB_Normal_CheckedChanged);
            // 
            // CB_NormalDX
            // 
            this.CB_NormalDX.AutoSize = true;
            this.CB_NormalDX.Location = new System.Drawing.Point(123, 136);
            this.CB_NormalDX.Name = "CB_NormalDX";
            this.CB_NormalDX.Size = new System.Drawing.Size(83, 17);
            this.CB_NormalDX.TabIndex = 6;
            this.CB_NormalDX.Text = "Normal (DX)";
            this.CB_NormalDX.UseVisualStyleBackColor = true;
            this.CB_NormalDX.CheckedChanged += new System.EventHandler(this.CB_NormalDX_CheckedChanged);
            // 
            // CB_Height
            // 
            this.CB_Height.AutoSize = true;
            this.CB_Height.Location = new System.Drawing.Point(123, 188);
            this.CB_Height.Name = "CB_Height";
            this.CB_Height.Size = new System.Drawing.Size(57, 17);
            this.CB_Height.TabIndex = 7;
            this.CB_Height.Text = "Height";
            this.CB_Height.UseVisualStyleBackColor = true;
            this.CB_Height.CheckedChanged += new System.EventHandler(this.CB_Height_CheckedChanged);
            // 
            // CB_Emissive
            // 
            this.CB_Emissive.AutoSize = true;
            this.CB_Emissive.Location = new System.Drawing.Point(212, 32);
            this.CB_Emissive.Name = "CB_Emissive";
            this.CB_Emissive.Size = new System.Drawing.Size(67, 17);
            this.CB_Emissive.TabIndex = 8;
            this.CB_Emissive.Text = "Emissive";
            this.CB_Emissive.UseVisualStyleBackColor = true;
            this.CB_Emissive.CheckedChanged += new System.EventHandler(this.CB_Emissive_CheckedChanged);
            // 
            // CB_Reflection
            // 
            this.CB_Reflection.AutoSize = true;
            this.CB_Reflection.Location = new System.Drawing.Point(294, 32);
            this.CB_Reflection.Name = "CB_Reflection";
            this.CB_Reflection.Size = new System.Drawing.Size(74, 17);
            this.CB_Reflection.TabIndex = 9;
            this.CB_Reflection.Text = "Reflection";
            this.CB_Reflection.UseVisualStyleBackColor = true;
            this.CB_Reflection.CheckedChanged += new System.EventHandler(this.CB_Reflection_CheckedChanged);
            // 
            // CB_Diffuse
            // 
            this.CB_Diffuse.AutoSize = true;
            this.CB_Diffuse.Location = new System.Drawing.Point(212, 84);
            this.CB_Diffuse.Name = "CB_Diffuse";
            this.CB_Diffuse.Size = new System.Drawing.Size(59, 17);
            this.CB_Diffuse.TabIndex = 10;
            this.CB_Diffuse.Text = "Diffuse";
            this.CB_Diffuse.UseVisualStyleBackColor = true;
            this.CB_Diffuse.CheckedChanged += new System.EventHandler(this.CB_Diffuse_CheckedChanged);
            // 
            // CB_Specular
            // 
            this.CB_Specular.AutoSize = true;
            this.CB_Specular.Location = new System.Drawing.Point(212, 136);
            this.CB_Specular.Name = "CB_Specular";
            this.CB_Specular.Size = new System.Drawing.Size(68, 17);
            this.CB_Specular.TabIndex = 11;
            this.CB_Specular.Text = "Specular";
            this.CB_Specular.UseVisualStyleBackColor = true;
            this.CB_Specular.CheckedChanged += new System.EventHandler(this.CB_Specular_CheckedChanged);
            // 
            // CB_Glossiness
            // 
            this.CB_Glossiness.AutoSize = true;
            this.CB_Glossiness.Location = new System.Drawing.Point(212, 188);
            this.CB_Glossiness.Name = "CB_Glossiness";
            this.CB_Glossiness.Size = new System.Drawing.Size(76, 17);
            this.CB_Glossiness.TabIndex = 12;
            this.CB_Glossiness.Text = "Glossiness";
            this.CB_Glossiness.UseVisualStyleBackColor = true;
            this.CB_Glossiness.CheckedChanged += new System.EventHandler(this.CB_Glossiness_CheckedChanged);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // B_BaseColorPicker
            // 
            this.B_BaseColorPicker.Location = new System.Drawing.Point(3, 3);
            this.B_BaseColorPicker.Name = "B_BaseColorPicker";
            this.B_BaseColorPicker.Size = new System.Drawing.Size(75, 23);
            this.B_BaseColorPicker.TabIndex = 13;
            this.B_BaseColorPicker.UseVisualStyleBackColor = true;
            this.B_BaseColorPicker.Click += new System.EventHandler(this.B_BaseColorPicker_Click);
            // 
            // B_RoughnessPicker
            // 
            this.B_RoughnessPicker.Location = new System.Drawing.Point(3, 55);
            this.B_RoughnessPicker.Name = "B_RoughnessPicker";
            this.B_RoughnessPicker.Size = new System.Drawing.Size(75, 23);
            this.B_RoughnessPicker.TabIndex = 14;
            this.B_RoughnessPicker.UseVisualStyleBackColor = true;
            this.B_RoughnessPicker.Click += new System.EventHandler(this.B_RoughnessPicker_Click);
            // 
            // B_AmbientOcclusionPicker
            // 
            this.B_AmbientOcclusionPicker.Location = new System.Drawing.Point(3, 159);
            this.B_AmbientOcclusionPicker.Name = "B_AmbientOcclusionPicker";
            this.B_AmbientOcclusionPicker.Size = new System.Drawing.Size(75, 23);
            this.B_AmbientOcclusionPicker.TabIndex = 15;
            this.B_AmbientOcclusionPicker.UseVisualStyleBackColor = true;
            this.B_AmbientOcclusionPicker.Click += new System.EventHandler(this.B_AmbientOcclusionPicker_Click);
            // 
            // B_IORPicker
            // 
            this.B_IORPicker.Location = new System.Drawing.Point(123, 3);
            this.B_IORPicker.Name = "B_IORPicker";
            this.B_IORPicker.Size = new System.Drawing.Size(75, 23);
            this.B_IORPicker.TabIndex = 16;
            this.B_IORPicker.UseVisualStyleBackColor = true;
            this.B_IORPicker.Click += new System.EventHandler(this.B_IORPicker_Click);
            // 
            // B_MetallicPicker
            // 
            this.B_MetallicPicker.Location = new System.Drawing.Point(3, 107);
            this.B_MetallicPicker.Name = "B_MetallicPicker";
            this.B_MetallicPicker.Size = new System.Drawing.Size(75, 23);
            this.B_MetallicPicker.TabIndex = 17;
            this.B_MetallicPicker.UseVisualStyleBackColor = true;
            this.B_MetallicPicker.Click += new System.EventHandler(this.B_MetallicPicker_Click);
            // 
            // B_NormalPicker
            // 
            this.B_NormalPicker.Location = new System.Drawing.Point(123, 55);
            this.B_NormalPicker.Name = "B_NormalPicker";
            this.B_NormalPicker.Size = new System.Drawing.Size(75, 23);
            this.B_NormalPicker.TabIndex = 18;
            this.B_NormalPicker.UseVisualStyleBackColor = true;
            this.B_NormalPicker.Click += new System.EventHandler(this.B_NormalPicker_Click);
            // 
            // B_NormalDXPicker
            // 
            this.B_NormalDXPicker.Location = new System.Drawing.Point(123, 107);
            this.B_NormalDXPicker.Name = "B_NormalDXPicker";
            this.B_NormalDXPicker.Size = new System.Drawing.Size(75, 23);
            this.B_NormalDXPicker.TabIndex = 19;
            this.B_NormalDXPicker.UseVisualStyleBackColor = true;
            this.B_NormalDXPicker.Click += new System.EventHandler(this.B_NormalDXPicker_Click);
            // 
            // B_HeightPicker
            // 
            this.B_HeightPicker.Location = new System.Drawing.Point(123, 159);
            this.B_HeightPicker.Name = "B_HeightPicker";
            this.B_HeightPicker.Size = new System.Drawing.Size(75, 23);
            this.B_HeightPicker.TabIndex = 20;
            this.B_HeightPicker.UseVisualStyleBackColor = true;
            this.B_HeightPicker.Click += new System.EventHandler(this.B_HeightPicker_Click);
            // 
            // B_EmissivePicker
            // 
            this.B_EmissivePicker.Location = new System.Drawing.Point(212, 3);
            this.B_EmissivePicker.Name = "B_EmissivePicker";
            this.B_EmissivePicker.Size = new System.Drawing.Size(75, 23);
            this.B_EmissivePicker.TabIndex = 21;
            this.B_EmissivePicker.UseVisualStyleBackColor = true;
            this.B_EmissivePicker.Click += new System.EventHandler(this.B_EmissivePicker_Click);
            // 
            // B_DiffusePicker
            // 
            this.B_DiffusePicker.Location = new System.Drawing.Point(212, 55);
            this.B_DiffusePicker.Name = "B_DiffusePicker";
            this.B_DiffusePicker.Size = new System.Drawing.Size(75, 23);
            this.B_DiffusePicker.TabIndex = 22;
            this.B_DiffusePicker.UseVisualStyleBackColor = true;
            this.B_DiffusePicker.Click += new System.EventHandler(this.B_DiffusePicker_Click);
            // 
            // B_SpecularPicker
            // 
            this.B_SpecularPicker.Location = new System.Drawing.Point(212, 107);
            this.B_SpecularPicker.Name = "B_SpecularPicker";
            this.B_SpecularPicker.Size = new System.Drawing.Size(75, 23);
            this.B_SpecularPicker.TabIndex = 23;
            this.B_SpecularPicker.UseVisualStyleBackColor = true;
            this.B_SpecularPicker.Click += new System.EventHandler(this.B_SpecularPicker_Click);
            // 
            // B_GlossinessPicker
            // 
            this.B_GlossinessPicker.Location = new System.Drawing.Point(212, 159);
            this.B_GlossinessPicker.Name = "B_GlossinessPicker";
            this.B_GlossinessPicker.Size = new System.Drawing.Size(75, 23);
            this.B_GlossinessPicker.TabIndex = 24;
            this.B_GlossinessPicker.UseVisualStyleBackColor = true;
            this.B_GlossinessPicker.Click += new System.EventHandler(this.B_GlossinessPicker_Click);
            // 
            // B_ReflectionPicker
            // 
            this.B_ReflectionPicker.Location = new System.Drawing.Point(294, 3);
            this.B_ReflectionPicker.Name = "B_ReflectionPicker";
            this.B_ReflectionPicker.Size = new System.Drawing.Size(75, 23);
            this.B_ReflectionPicker.TabIndex = 25;
            this.B_ReflectionPicker.UseVisualStyleBackColor = true;
            this.B_ReflectionPicker.Click += new System.EventHandler(this.B_ReflectionPicker_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CB_FileType);
            this.Controls.Add(this.TxtBx_FileName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.B_Combine_Images);
            this.Controls.Add(this.B_Destination_Folder);
            this.Controls.Add(this.B_Source_Folder_Button);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Source_Folder_Button;
        private System.Windows.Forms.Button B_Destination_Folder;
        private System.Windows.Forms.Button B_Combine_Images;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
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
        private System.Windows.Forms.Button button1;
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
    }
}

