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
using Newtonsoft.Json;

namespace Substance_Map_Combiner
{
    public partial class MainWindow : Form
    {
        private string _SourceFolder = @"J:\Substance Painter Files\Substance Exports\Giant Mech\Giant Mech Maps\Giant Mech Body";
        private string _DestinationFolder = @"J:\Substance Painter Files\Substance Exports\Giant Mech\Giant Mech Maps\Test";
        private string _PreferenceFileLocation = "Preferences.pref";
        private UserPreferences _UserPreferences = null;

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
            AddNewMap (MapTypes.BaseColor, "_Base_Color", Color.WhiteSmoke);
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
            SetupCheckBoxEvents ();
            UpdateButton (B_BaseColorPicker, MapTypes.BaseColor);
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

            TxtBx_FileName.Text = _UserPreferences.ExportFileName;
            CB_FileType.Text = _UserPreferences.ExportFileType;
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
                //TODO: Make it so that if the user selects a source folder with no files a warning pop's up telling them so.
                //TODO: Refactor this whole thing by making the buttons generate on setup and make them part of the map profile. 
                //That way, we can keep them under one accessible array/list/dictionary. Think of the hentai steam client.
                _SourceFolder = fileDialog.FileName;

                CheckFolderForFiles ();
            }
        }

        private void CheckFolderForFiles ()
        {
            string[] files = GetFiles ();

            if (files == null)
                return;

            // Loop through every map type.
            foreach (KeyValuePair<MapTypes, Map> map in _Maps)
            {
                PreselectImagesFromFolder (map, files);
            }
        }

        private void PreselectImagesFromFolder (KeyValuePair<MapTypes, Map> map, string[] files)
        {
            // Determine if the map type is in the current image list by filtering if it's suffix can be found.
            string[] images = GetFilesWithSuffix (map.Value.Suffixes, files);

            // If it's suffix can be found then perform more logic as it's in the folder.
            if (images != null)
            {
                // Set the map to be selected as it's in the folder.
                map.Value.IsSelected = true;

                var checkBox = GetCheckBoxFromMapType (map.Key);

                if (checkBox != null)
                    checkBox.Checked = true;
            }
        }

        private CheckBox GetCheckBoxFromMapType (MapTypes mapType)
        {
            // Grab all of the controls and loop through them.
            var controls = flowLayoutPanel1.Controls;
            string tag = mapType.ToString ();

            foreach (var control in controls)
            {
                // If it's a checkbox that corresponds with the map then set it to checked.
                if (control is CheckBox checkBox)
                    if ((string)checkBox.Tag == tag)
                        return checkBox;
            }

            return null;
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
            CombineImages ();
        }

        private void CombineImages ()
        {
            string[] files = GetFiles ();

            if (files == null)
                return;

            foreach (KeyValuePair<MapTypes, Map> map in _Maps)
            {
                if (map.Value.IsSelected)
                {
                    CreateCombinedImageMap (map.Value, files);
                }
            }
        }

        /// <summary>
        /// Find and returns any image file types found within the source folder.
        /// </summary>
        /// <returns></returns>
        private string[] GetFiles ()
        {
            string[] extensions = new[] { ".jpeg", ".jpg", ".png", ".tga", ".tiff" };

            if (extensions != null)
            {
                string[] files = Directory
                .GetFiles (_SourceFolder)
                .Where (file => extensions.Any (file.ToLower ().EndsWith))
                .ToArray ();

                return files;
            }

            return null;
        }

        private void CreateCombinedImageMap (Map map, string[] files)
        {
            string[] images = GetFilesWithSuffix (map.Suffixes, files);
            string mapName = _UserPreferences.ExportFileName + map.OutputSuffix + _UserPreferences.ExportFileType;

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

        private void SetupCheckBoxEvents ()
        {
            checkBox1.CheckedChanged += ChB_CheckedChanged;
            CB_Roughness.CheckedChanged += ChB_CheckedChanged;
            CB_Metallic.CheckedChanged += ChB_CheckedChanged;
            CB_Ambient_Occlusion.CheckedChanged += ChB_CheckedChanged;
            CB_IOR.CheckedChanged += ChB_CheckedChanged;
            CB_Normal.CheckedChanged += ChB_CheckedChanged;
            CB_NormalDX.CheckedChanged += ChB_CheckedChanged;
            CB_Height.CheckedChanged += ChB_CheckedChanged;
            CB_Emissive.CheckedChanged += ChB_CheckedChanged;
            CB_Diffuse.CheckedChanged += ChB_CheckedChanged;
            CB_Specular.CheckedChanged += ChB_CheckedChanged;
            CB_Glossiness.CheckedChanged += ChB_CheckedChanged;
            CB_Reflection.CheckedChanged += ChB_CheckedChanged;
        }

        private void ChB_CheckedChanged (object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox != null)
                {
                    string tag = (string)checkBox.Tag;

                    if (Enum.TryParse (tag, out MapTypes mapType))
                    {
                        SelectMap (checkBox, mapType);
                    }
                }
            }
        }

        private void SelectMap (CheckBox checkBox, MapTypes mapType)
        {
            _Maps[mapType].IsSelected = checkBox.Checked;
        }
        
        private void TxtBx_FileName_TextChanged (object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox != null)
                    _UserPreferences.ExportFileName = textBox.Text;
            }
        }

        private void CB_FileType_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                if (comboBox != null)
                    _UserPreferences.ExportFileType = comboBox.Text;
            }
        }

        #region Color Boxes

        

        private void B_BaseColorPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    _Maps[MapTypes.BaseColor].BackgroundColor = GetBackgroundColor (button);
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

        private void ResetColorToDefault (Button button, Map map)
        {
            map.BackgroundColor = map.DefaultBackgroundColor;
            button.BackColor = map.DefaultBackgroundColor;
        }

        private void B_BaseColorPicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var map = _UserPreferences.GetMap (MapTypes.BaseColor);
                ResetColorToDefault (sender as Button, map);
            }
        }

        private void B_RoughnessPicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var map = _UserPreferences.GetMap (MapTypes.Roughness);
                ResetColorToDefault (sender as Button, map);
            }
        }

        private void B_MetallicPicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var map = _UserPreferences.GetMap (MapTypes.Metallic);
                ResetColorToDefault (sender as Button, map);
            }
        }

        private void B_AmbientOcclusionPicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var map = _UserPreferences.GetMap (MapTypes.AO);
                ResetColorToDefault (sender as Button, map);
            }
        }

        private void B_IORPicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var map = _UserPreferences.GetMap (MapTypes.IOR);
                ResetColorToDefault (sender as Button, map);
            }
        }

        private void B_NormalPicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var map = _UserPreferences.GetMap (MapTypes.Normal);
                ResetColorToDefault (sender as Button, map);
            }
        }

        private void B_NormalDXPicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var map = _UserPreferences.GetMap (MapTypes.NormalDX);
                ResetColorToDefault (sender as Button, map);
            }
        }

        private void B_HeightPicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var map = _UserPreferences.GetMap (MapTypes.Height);
                ResetColorToDefault (sender as Button, map);
            }
        }

        private void B_EmissivePicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var map = _UserPreferences.GetMap (MapTypes.Emissive);
                ResetColorToDefault (sender as Button, map);
            }
        }

        private void B_DiffusePicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var map = _UserPreferences.GetMap (MapTypes.Diffuse);
                ResetColorToDefault (sender as Button, map);
            }
        }

        private void B_SpecularPicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var map = _UserPreferences.GetMap (MapTypes.Specular);
                ResetColorToDefault (sender as Button, map);
            }
        }

        private void B_GlossinessPicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var map = _UserPreferences.GetMap (MapTypes.Glossiness);
                ResetColorToDefault (sender as Button, map);
            }
        }

        private void B_ReflectionPicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var map = _UserPreferences.GetMap (MapTypes.Reflection);
                ResetColorToDefault (sender as Button, map);
            }
        }
    }
}
