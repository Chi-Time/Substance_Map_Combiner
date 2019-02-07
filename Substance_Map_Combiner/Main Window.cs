using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Substance_Map_Combiner
{
    public partial class MainWindow : Form
    {
        private string _FileName = "Combined";
        private string _FileType = ".png";
        private string _SourceFolder = @"J:\Substance Painter Files\Substance Exports\Giant Mech\Giant Mech Maps\Giant Mech Body";
        private string _DestinationFolder = @"J:\Substance Painter Files\Substance Exports\Giant Mech\Giant Mech Maps\Test";
        private List<string> _OverlayImages = new List<string> ();

        private List<string> _BaseColorSuffixes = new List<string> ();
        private List<string> _RoughnessSuffixes = new List<string> ();
        private List<string> _MetallicSuffixes = new List<string> ();
        private List<string> _AmbientOcclusionSuffixes = new List<string> ();
        private List<string> _IORSuffixes = new List<string> ();
        private List<string> _NormalSuffixes = new List<string> ();
        private List<string> _NormalDXSuffixes = new List<string> ();
        private List<string> _HeightSuffixes = new List<string> ();
        private List<string> _EmissiveSuffixes = new List<string> ();
        private List<string> _ReflectionSuffixes = new List<string> ();
        private List<string> _DiffuseSuffixes = new List<string> ();
        private List<string> _SpecularSuffixes = new List<string> ();
        private List<string> _GlossinessSuffixes = new List<string> ();

        private Color _BaseColorBackground = Color.WhiteSmoke;
        private Color _RoughnessBackground = Color.DarkGray;
        private Color _MetallicBackground = Color.DimGray;
        private Color _AmbientOcclusionBackground = Color.White;
        private Color _IORBackground = Color.WhiteSmoke;
        private Color _NormalBackground = Color.FromArgb (128, 128, 255);
        private Color _NormalDXBackground = Color.FromArgb (128, 128, 255);
        private Color _HeightBackground = Color.DarkGray;
        private Color _EmissiveBackground = Color.WhiteSmoke;
        private Color _ReflectionBackground = Color.WhiteSmoke;
        private Color _DiffuseBackground = Color.WhiteSmoke;
        private Color _SpecularBackground = Color.WhiteSmoke;
        private Color _GlossinessBackground = Color.WhiteSmoke;

        private bool _IsBaseColor = false;
        private bool _IsRoughness = false;
        private bool _IsMetallic = false;
        private bool _IsAmbient_Occlusion = false;
        private bool _IsIOR = false;
        private bool _IsNormal = false;
        private bool _IsNormalDX = false;
        private bool _IsHeight = false;
        private bool _IsEmissive = false;
        private bool _IsReflection = false;
        private bool _IsDiffuse = false;
        private bool _IsSpecular = false;
        private bool _IsGlossiness = false;

        public MainWindow ()
        {
            InitializeComponent ();
        }

        private void Main_Window_Load (object sender, EventArgs e)
        {
            _BaseColorSuffixes.Add ("_Base_Color");
            _RoughnessSuffixes.Add ("_Roughness");
            _MetallicSuffixes.Add ("_Metallic");
            _AmbientOcclusionSuffixes.Add ("_Ambient_occlusion");
            _IORSuffixes.Add ("_IOR");
            _NormalSuffixes.Add ("_Normal");
            _NormalDXSuffixes.Add ("_NormalDX");
            _HeightSuffixes.Add ("_Height");
            _EmissiveSuffixes.Add ("_Emissive");
            _ReflectionSuffixes.Add ("_Reflections");
            _DiffuseSuffixes.Add ("_Diffuse");
            _SpecularSuffixes.Add ("_Specular");
            _GlossinessSuffixes.Add ("_Glossiness");

            TxtBx_FileName.Text = _FileName;
            CB_FileType.Text = _FileType;

            B_BaseColorPicker.BackColor = _BaseColorBackground;
            B_RoughnessPicker.BackColor = _RoughnessBackground;
            B_MetallicPicker.BackColor = _MetallicBackground;
            B_AmbientOcclusionPicker.BackColor = _AmbientOcclusionBackground;
            B_IORPicker.BackColor = _IORBackground;
            B_NormalPicker.BackColor = _NormalBackground;
            B_NormalDXPicker.BackColor = _NormalDXBackground;
            B_HeightPicker.BackColor = _HeightBackground;
            B_EmissivePicker.BackColor = _EmissiveBackground;
            B_ReflectionPicker.BackColor = _ReflectionBackground;
            B_DiffusePicker.BackColor = _DiffuseBackground;
            B_SpecularPicker.BackColor = _SpecularBackground;
            B_GlossinessPicker.BackColor = _GlossinessBackground;
        }

        private void B_Source_Folder_Button_Click (object sender, EventArgs e)
        {
            var fileDialog = new FolderSelectDialog ();

            if (fileDialog.ShowDialog ())
            {
                _SourceFolder = fileDialog.FileName;
            }
        }

        private void B_Destination_Folder_Click (object sender, EventArgs e)
        {
            var fileDialog = new FolderSelectDialog ();

            if (fileDialog.ShowDialog ())
            {
                _DestinationFolder = fileDialog.FileName;
            }
        }

        private void B_Combine_Images_Click (object sender, EventArgs e)
        {
            string[] extensions = new [] { ".jpeg", ".jpg", ".png", ".tga", ".tiff"};
            string[] files = Directory
                .GetFiles (_SourceFolder)
                .Where (file => extensions.Any (file.ToLower ().EndsWith))
                .ToArray ();

            if (_IsBaseColor)
            {
                //TODO: Make it so that we add the suffix the user is using at the end of each map type. So don't just assume it's _Base_Color and make it the suffix of their choice.
                CreateMap (_BaseColorSuffixes, files, "_Base_Color", _BaseColorBackground);
            }
            if (_IsRoughness)
            {
                CreateMap (_RoughnessSuffixes, files, "_Roughness", _RoughnessBackground);

                Console.WriteLine ("Roughness Pass");
            }
            if (_IsMetallic)
            {
                CreateMap (_MetallicSuffixes, files, "_Metallic", _MetallicBackground);
            }
            if (_IsAmbient_Occlusion)
            {
                CreateMap (_AmbientOcclusionSuffixes, files, "_Ambient_occlusion", _AmbientOcclusionBackground);
            }
            if (_IsIOR)
            {
                CreateMap (_IORSuffixes, files, "_IOR", _IORBackground);
            }
            if (_IsNormal)
            {
                CreateMap (_NormalSuffixes, files, "_Normal", _NormalBackground);
            }
            if (_IsNormalDX)
            {
                CreateMap (_NormalDXSuffixes, files, "_NormalDX", _NormalDXBackground);
            }
            if (_IsHeight)
            {
                CreateMap (_HeightSuffixes, files, "_Height", _HeightBackground);
            }
            if (_IsEmissive)
            {
                CreateMap (_EmissiveSuffixes, files, "_Emissive", _EmissiveBackground);
            }
            if (_IsReflection)
            {
                CreateMap (_ReflectionSuffixes, files, "_Reflection", _ReflectionBackground);
            }
            if (_IsDiffuse)
            {
                CreateMap (_DiffuseSuffixes, files, "_Diffuse", _DiffuseBackground);
            }
            if (_IsSpecular)
            {
                CreateMap (_SpecularSuffixes, files, "_Specular", _SpecularBackground);
            }
            if (_IsGlossiness)
            {
                CreateMap (_GlossinessSuffixes, files, "_Glossiness", _GlossinessBackground);
            }
        }

        private void CreateMap (List<string> suffixes, string[] files, string mapType, Color color)
        {
            string[] images = GetFilesWithSuffix (suffixes, files);
            string mapName = _FileName + mapType + _FileType;

            if (images != null)
            {
                ImageCombiner.CombineImages (images[0], images.ToArray (), _DestinationFolder, mapName, color);

                return;
            }
        }

        private string[] GetFilesWithSuffix (List<string> suffixes, string[] files)
        {
            foreach (string suffix in suffixes)
            {
                var images = new List<string> ();

                foreach (string file in files)
                    if (file.Contains (suffix))
                        images.Add (file);

                if (images.Count > 0)
                    return images.ToArray ();
            }

            return null;
        }

        #region Checkboxes

        private void checkBox1_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _IsBaseColor = checkBox.Checked;
            }
        }

        private void CB_Roughness_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _IsRoughness = checkBox.Checked;
            }
        }

        private void CB_Metallic_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _IsMetallic = checkBox.Checked;
            }
        }

        private void CB_Ambient_Occlusion_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _IsAmbient_Occlusion = checkBox.Checked;
            }
        }

        private void CB_IOR_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _IsIOR = checkBox.Checked;
            }
        }

        private void CB_Normal_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _IsNormal = checkBox.Checked;
            }
        }

        private void CB_NormalDX_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _IsNormalDX = checkBox.Checked;
            }
        }

        private void CB_Height_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _IsHeight = checkBox.Checked;
            }
        }

        private void CB_Emissive_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _IsEmissive = checkBox.Checked;
            }
        }

        private void CB_Reflection_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _IsReflection = checkBox.Checked;
            }
        }

        private void CB_Diffuse_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _IsDiffuse = checkBox.Checked;
            }
        }

        private void CB_Specular_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _IsSpecular = checkBox.Checked;
            }
        }

        private void CB_Glossiness_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _IsGlossiness = checkBox.Checked;
            }
        }

        #endregion

        private void TxtBx_FileName_TextChanged (object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox != null)
                    _FileName = textBox.Text;
            }
        }

        private void CB_FileType_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                if (comboBox != null)
                    _FileType = comboBox.Text;
            }

            Console.WriteLine (_FileType);
        }

        private void B_BaseColorPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _BaseColorBackground = GetBackgroundColor (button);
                }
            }
        }

        private void B_RoughnessPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _RoughnessBackground = GetBackgroundColor (button);
                }
            }
        }

        private void B_MetallicPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _MetallicBackground = GetBackgroundColor (button);
                }
            }
        }

        private void B_AmbientOcclusionPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _AmbientOcclusionBackground = GetBackgroundColor (button);
                }
            }
        }

        private void B_IORPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _IORBackground = GetBackgroundColor (button);
                }
            }
        }

        private void B_NormalPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _NormalBackground = GetBackgroundColor (button);
                }
            }
        }

        private void B_NormalDXPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _NormalDXBackground = GetBackgroundColor (button);
                }
            }
        }

        private void B_HeightPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _HeightBackground = GetBackgroundColor (button);
                }
            }
        }

        private void B_EmissivePicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _EmissiveBackground = GetBackgroundColor (button);
                }
            }
        }

        private void B_DiffusePicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _DiffuseBackground = GetBackgroundColor (button);
                }
            }
        }

        private void B_SpecularPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _SpecularBackground = GetBackgroundColor (button);
                }
            }
        }

        private void B_GlossinessPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _GlossinessBackground = GetBackgroundColor (button);
                }
            }
        }

        private void B_ReflectionPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _ReflectionBackground = GetBackgroundColor (button);
                }
            }
        }

        private Color GetBackgroundColor (Button button)
        {
            var colorDialog = new ColorDialog ()
            {
                AllowFullOpen = true,
                SolidColorOnly = false,
                ShowHelp = true,
                Color = button.BackColor
            };

            if (colorDialog.ShowDialog () == DialogResult.OK)
            {
                button.BackColor = colorDialog.Color;
                return colorDialog.Color;
            }

            return button.BackColor;
        }
    }
}
