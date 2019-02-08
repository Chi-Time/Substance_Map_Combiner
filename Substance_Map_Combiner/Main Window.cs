﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Substance_Map_Combiner
{
    public partial class MainWindow : Form
    {
        private string _FileName = "Combined";
        private string _FileType = ".png";
        private string _SourceFolder = @"J:\Substance Painter Files\Substance Exports\Giant Mech\Giant Mech Maps\Giant Mech Body";
        private string _DestinationFolder = @"J:\Substance Painter Files\Substance Exports\Giant Mech\Giant Mech Maps\Test";
        private string _PreferenceFileLocation = "Preferences.pref";
        private UserPreferences _UserPreferences = null;

        //private Map _BaseColor = new Map ();
        //private Map _Roughness = new Map ();
        //private Map _Metallic = new Map ();
        //private Map _AmbientOcclusion = new Map ();
        //private Map _IOR = new Map ();
        //private Map _Normal = new Map ();
        //private Map _NormalDX = new Map ();
        //private Map _Height = new Map ();
        //private Map _Emissive = new Map ();
        //private Map _Reflection = new Map ();
        //private Map _Diffuse = new Map ();
        //private Map _Specular = new Map ();
        //private Map _Glossiness = new Map ();

        private Dictionary<MapTypes, Map> _Maps = new Dictionary<MapTypes, Map> ();

        public MainWindow ()
        {
            InitializeComponent ();

            if (!File.Exists (_PreferenceFileLocation))
            {
                InitialiseDefaultPreferences ();
            }
            else
            {
                string json = File.ReadAllText (_PreferenceFileLocation);
                _UserPreferences = JsonConvert.DeserializeObject<UserPreferences> (json);

                if (_UserPreferences != null)
                {
                    _Maps = _UserPreferences.Maps;
                }
            }
        }

        private void InitialiseDefaultPreferences ()
        {
            /*
            _BaseColor.Suffixes.Add ("_Base_Color");
            _Roughness.Suffixes.Add ("_Roughness");
            _Metallic.Suffixes.Add ("_Metallic");
            _AmbientOcclusion.Suffixes.Add ("_Ambient_occlusion");
            _IOR.Suffixes.Add ("_IOR");
            _Normal.Suffixes.Add ("_Normal");
            _NormalDX.Suffixes.Add ("_NormalDX");
            _Height.Suffixes.Add ("_Height");
            _Emissive.Suffixes.Add ("_Emissive");
            _Reflection.Suffixes.Add ("_Reflections");
            _Diffuse.Suffixes.Add ("_Diffuse");
            _Specular.Suffixes.Add ("_Specular");
            _Glossiness.Suffixes.Add ("_Glossiness");

            _BaseColor.OutputSuffix = ("_Base_Color");
            _Roughness.OutputSuffix = ("_Roughness");
            _Metallic.OutputSuffix = ("_Metallic");
            _AmbientOcclusion.OutputSuffix = ("_Ambient_occlusion");
            _IOR.OutputSuffix = ("_IOR");
            _Normal.OutputSuffix = ("_Normal");
            _NormalDX.OutputSuffix = ("_NormalDX");
            _Height.OutputSuffix = ("_Height");
            _Emissive.OutputSuffix = ("_Emissive");
            _Reflection.OutputSuffix = ("_Reflections");
            _Diffuse.OutputSuffix = ("_Diffuse");
            _Specular.OutputSuffix = ("_Specular");
            _Glossiness.OutputSuffix = ("_Glossiness");

            _BaseColor.BackgroundColor = Color.WhiteSmoke;
            _Roughness.BackgroundColor = Color.DarkGray;
            _Metallic.BackgroundColor = Color.DimGray;
            _AmbientOcclusion.BackgroundColor = Color.White;
            _IOR.BackgroundColor = Color.WhiteSmoke;
            _Normal.BackgroundColor = Color.FromArgb (128, 128, 255);
            _NormalDX.BackgroundColor = Color.FromArgb (128, 128, 255);
            _Height.BackgroundColor = Color.DarkGray;
            _Emissive.BackgroundColor = Color.WhiteSmoke;
            _Reflection.BackgroundColor = Color.WhiteSmoke;
            _Diffuse.BackgroundColor = Color.WhiteSmoke;
            _Specular.BackgroundColor = Color.WhiteSmoke;
            _Glossiness.BackgroundColor = Color.WhiteSmoke;*/

            AddNewMap (MapTypes.Base_Color, "_Base_Color", Color.WhiteSmoke);
            AddNewMap (MapTypes.Roughness, "_Roughness", Color.DarkGray);
            AddNewMap (MapTypes.Metallic, "_Metallic", Color.DimGray);
            AddNewMap (MapTypes.AO, "_Ambient_occlusion", Color.White);
            AddNewMap (MapTypes.IOR, "_IOR", Color.WhiteSmoke);
            AddNewMap (MapTypes.Normal, "_Normal", Color.FromArgb (128, 128, 255));
            AddNewMap (MapTypes.NormalDX, "_NormalDX", Color.FromArgb (128, 128, 255));
            AddNewMap (MapTypes.Height, "_Height", Color.DarkGray);
            AddNewMap (MapTypes.Emissive, "_Emissive", Color.WhiteSmoke);
            AddNewMap (MapTypes.Reflection, "_Reflection", Color.WhiteSmoke);
            AddNewMap (MapTypes.Diffuse, "_Diffuse", Color.WhiteSmoke);
            AddNewMap (MapTypes.Specular, "_Specular", Color.WhiteSmoke);
            AddNewMap (MapTypes.Glossiness, "_Glossiness", Color.WhiteSmoke);

            _UserPreferences = new UserPreferences
            {
                Maps = _Maps
            };
        }

        private void AddNewMap (MapTypes mapType, string suffix, Color color)
        {
            _Maps.Add (mapType, new Map ());
            _Maps[mapType].Suffixes.Add (suffix);
            _Maps[mapType].DefaultSuffix = suffix;
            _Maps[mapType].OutputSuffix = (suffix);
            _Maps[mapType].BackgroundColor = color;
            _Maps[mapType].DefaultBackgroundColor = color;
        }

        private void Main_Window_Load (object sender, EventArgs e)
        {
            InitialiseInterface ();
        }

        private void InitialiseInterface ()
        {
            UpdateButton (B_BaseColorPicker, MapTypes.Base_Color);
            UpdateButton (B_RoughnessPicker, MapTypes.Roughness);
            UpdateButton (B_MetallicPicker, MapTypes.Metallic);
            UpdateButton (B_AmbientOcclusionPicker, MapTypes.AO);
            UpdateButton (B_IORPicker, MapTypes.IOR);
            UpdateButton (B_NormalPicker, MapTypes.Normal);
            UpdateButton (B_NormalDXPicker, MapTypes.NormalDX);
            UpdateButton (B_HeightPicker, MapTypes.Height);
            UpdateButton (B_EmissivePicker, MapTypes.Emissive);
            UpdateButton (B_ReflectionPicker, MapTypes.Reflection);
            UpdateButton (B_DiffusePicker, MapTypes.Diffuse);
            UpdateButton (B_SpecularPicker, MapTypes.Specular);
            UpdateButton (B_GlossinessPicker, MapTypes.Glossiness);

            TxtBx_FileName.Text = _FileName;
            CB_FileType.Text = _FileType;
        }

        private void UpdateButton (Button button, MapTypes mapType)
        {
            button.BackColor = _Maps[mapType].BackgroundColor;
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

            foreach (KeyValuePair<MapTypes, Map> map in _Maps)
            {
                if (map.Value.IsSelected)
                {
                    CreateMap (map.Value, files);
                }
            }
        }

        private void CreateMap (Map map, string[] files)
        {
            string[] images = GetFilesWithSuffix (map.Suffixes, files);
            string mapName = _FileName + map.OutputSuffix + _FileType;

            if (images != null)
            {
                ImageCombiner.CombineImages (images[0], images.ToArray (), _DestinationFolder, mapName, map.BackgroundColor);

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

        private void CB_Base_Color_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _Maps[MapTypes.Base_Color].IsSelected = checkBox.Checked;
            }
        }

        private void CB_Roughness_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _Maps[MapTypes.Roughness].IsSelected = checkBox.Checked;
            }
        }

        private void CB_Metallic_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _Maps[MapTypes.Metallic].IsSelected = checkBox.Checked;
            }
        }

        private void CB_Ambient_Occlusion_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _Maps[MapTypes.AO].IsSelected = checkBox.Checked;
            }
        }

        private void CB_IOR_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _Maps[MapTypes.IOR].IsSelected = checkBox.Checked;
            }
        }

        private void CB_Normal_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _Maps[MapTypes.Normal].IsSelected = checkBox.Checked;
            }
        }

        private void CB_NormalDX_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _Maps[MapTypes.NormalDX].IsSelected = checkBox.Checked;
            }
        }

        private void CB_Height_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _Maps[MapTypes.Height].IsSelected = checkBox.Checked;
            }
        }

        private void CB_Emissive_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _Maps[MapTypes.Emissive].IsSelected = checkBox.Checked;
            }
        }

        private void CB_Reflection_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _Maps[MapTypes.Reflection].IsSelected = checkBox.Checked;
            }
        }

        private void CB_Diffuse_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _Maps[MapTypes.Diffuse].IsSelected = checkBox.Checked;
            }
        }

        private void CB_Specular_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _Maps[MapTypes.Specular].IsSelected = checkBox.Checked;
            }
        }

        private void CB_Glossiness_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                    _Maps[MapTypes.Glossiness].IsSelected = checkBox.Checked;
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
        }

        #region Color Boxes

        private void B_BaseColorPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _Maps[MapTypes.Base_Color].BackgroundColor = GetBackgroundColor (button);
                }
            }
        }

        private void B_RoughnessPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _Maps[MapTypes.Roughness].BackgroundColor = GetBackgroundColor (button);
                }
            }
        }

        private void B_MetallicPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _Maps[MapTypes.Metallic].BackgroundColor = GetBackgroundColor (button);
                }
            }
        }

        private void B_AmbientOcclusionPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _Maps[MapTypes.AO].BackgroundColor = GetBackgroundColor (button);
                }
            }
        }

        private void B_IORPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _Maps[MapTypes.IOR].BackgroundColor = GetBackgroundColor (button);
                }
            }
        }

        private void B_NormalPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _Maps[MapTypes.Normal].BackgroundColor = GetBackgroundColor (button);
                }
            }
        }

        private void B_NormalDXPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _Maps[MapTypes.NormalDX].BackgroundColor = GetBackgroundColor (button);
                }
            }
        }

        private void B_HeightPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _Maps[MapTypes.Height].BackgroundColor = GetBackgroundColor (button);
                }
            }
        }

        private void B_EmissivePicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _Maps[MapTypes.Emissive].BackgroundColor = GetBackgroundColor (button);
                }
            }
        }

        private void B_DiffusePicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _Maps[MapTypes.Diffuse].BackgroundColor = GetBackgroundColor (button);
                }
            }
        }

        private void B_SpecularPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _Maps[MapTypes.Specular].BackgroundColor = GetBackgroundColor (button);
                }
            }
        }

        private void B_GlossinessPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _Maps[MapTypes.Glossiness].BackgroundColor = GetBackgroundColor (button);
                }
            }
        }

        private void B_ReflectionPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _Maps[MapTypes.Reflection].BackgroundColor = GetBackgroundColor (button);
                }
            }
        }

        #endregion

        private Color GetBackgroundColor (Button button)
        {
            var colorDialog = new ColorDialog ()
            {
                AllowFullOpen = true,
                SolidColorOnly = false,
                ShowHelp = true,
                AnyColor = true,
                Color = button.BackColor
            };

            if (colorDialog.ShowDialog () == DialogResult.OK)
            {
                button.BackColor = colorDialog.Color;
                return colorDialog.Color;
            }

            return button.BackColor;
        }

        private void TSMI_Preferences_Click (object sender, EventArgs e)
        {
            var preferenceWindow = new Preferences_Window (_UserPreferences);

            preferenceWindow.Show ();
        }

        private void MainWindow_FormClosing (object sender, FormClosingEventArgs e)
        {
            var json = UserPreferences.GetJSON (_UserPreferences);
            File.WriteAllText (_PreferenceFileLocation, json);
        }

        private void B_BaseColorPicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var map = _UserPreferences.GetMap (MapTypes.Base_Color);
                map.BackgroundColor = map.DefaultBackgroundColor;

                if (sender is Button button)
                    button.BackColor = map.DefaultBackgroundColor;
            }
        }
    }
}
