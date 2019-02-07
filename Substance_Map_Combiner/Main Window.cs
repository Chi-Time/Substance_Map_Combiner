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

            //foreach (string file in files)
            //    Console.WriteLine (file + "/n");

            if (_IsBaseColor)
            {
                //TODO: Make it so that we add the suffix the user is using at the end of each map type. So don't just assume it's _Base_Color and make it the suffix of their choice.
                CreateMap (_BaseColorSuffixes, files, "_Base_Color");
            }
            if (_IsRoughness)
            {
                CreateMap (_RoughnessSuffixes, files, "_Roughness");

                Console.WriteLine ("Roughness Pass");
            }
            if (_IsMetallic)
            {
                CreateMap (_MetallicSuffixes, files, "_Metallic");
            }
            if (_IsAmbient_Occlusion)
            {
                CreateMap (_AmbientOcclusionSuffixes, files, "_Ambient_occlusion");
            }
            if (_IsIOR)
            {
                CreateMap (_IORSuffixes, files, "_IOR");
            }
            if (_IsNormal)
            {
                CreateMap (_NormalSuffixes, files, "_Normal");
            }
            if (_IsNormalDX)
            {
                CreateMap (_NormalDXSuffixes, files, "_NormalDX");
            }
            if (_IsHeight)
            {
                CreateMap (_HeightSuffixes, files, "_Height");
            }
            if (_IsEmissive)
            {
                CreateMap (_EmissiveSuffixes, files, "_Emissive");
            }
            if (_IsReflection)
            {
                CreateMap (_ReflectionSuffixes, files, "_Reflection");
            }
            if (_IsDiffuse)
            {
                CreateMap (_DiffuseSuffixes, files, "_Diffuse");
            }
            if (_IsSpecular)
            {
                CreateMap (_SpecularSuffixes, files, "_Specular");
            }
            if (_IsGlossiness)
            {
                CreateMap (_GlossinessSuffixes, files, "_Glossiness");
            }
        }

        private void CreateMap (List<string> suffixes, string[] files, string mapType)
        {
            string[] images = GetFilesWithSuffix (suffixes, files);
            string mapName = _FileName + mapType + _FileType;

            if (images != null)
            {
                //TODO: Make it so that we add the suffix the user is using at the end of each map type. So don't just assume it's _Base_Color and make it the suffix of their choice.
                ImageCombiner.CombineImages (images[0], images.ToArray (), _DestinationFolder, mapName);

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
    }
}
