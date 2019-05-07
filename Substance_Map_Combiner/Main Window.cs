﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

//TODO: Fix memory issues (if that's even possible in C#, maybe consider C++ for this task instead.)
//TODO: Refactor this whole thing by making the buttons generate on setup and make them part of the map profile. 
//That way, we can keep them under one accessible array/list/dictionary. Think of the hentai steam client.

namespace Substance_Map_Combiner
{
    public partial class MainWindow : Form
    {
        private string _PreferenceFileLocation = "Preferences.pref";
        private UserPreferences _UserPreferences = null;
        private ImageCombiner _ImageCombiner = null;

        private readonly BackgroundWorker _Worker = null;
        private Dictionary<MapTypes, Map> _Maps = new Dictionary<MapTypes, Map> ();
        private Dictionary<MapTypes, string[]> _MapSegments = new Dictionary<MapTypes, string[]> ();

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
                    CheckFolderFiles (_UserPreferences.SourceFolder);
                }
            }

            _Worker = new BackgroundWorker ();
            _Worker.WorkerReportsProgress = true;
            _Worker.DoWork += CombineImagesAsync;
            _Worker.ProgressChanged += worker_ProgressChanged;
            _Worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }

        private void InitialiseDefaultPreferences ()
        {
            AddNewMap (MapTypes.BaseColor, "_Base_Color", Color.WhiteSmoke);
            AddNewMap (MapTypes.Roughness, "_Roughness", Color.DarkGray);
            AddNewMap (MapTypes.Metallic, "_Metallic", Color.DimGray);
            AddNewMap (MapTypes.AO, "_Ambient_occlusion", Color.White);
            AddNewMap (MapTypes.IOR, "_IOR", Color.WhiteSmoke);
            AddNewMap (MapTypes.Normal, "_Normal", Color.FromArgb (128, 128, 255));
            AddNewMap (MapTypes.Normal_DirectX, "_Normal_DirectX", Color.FromArgb (128, 128, 255));
            AddNewMap (MapTypes.Height, "_Height", Color.DarkGray);
            AddNewMap (MapTypes.Emissive, "_Emissive", Color.WhiteSmoke);
            AddNewMap (MapTypes.Reflection, "_Reflection", Color.WhiteSmoke);
            AddNewMap (MapTypes.Diffuse, "_Diffuse", Color.WhiteSmoke);
            AddNewMap (MapTypes.Specular, "_Specular", Color.WhiteSmoke);
            AddNewMap (MapTypes.Glossiness, "_Glossiness", Color.WhiteSmoke);
            AddNewMap (MapTypes.Displacement, "_Displacement", Color.WhiteSmoke);
            AddNewMap (MapTypes.Mixed_AO, "_Mixed_AO", Color.DarkGray);

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
            SetupButtonClickEvents ();
            UpdateColorButtons ();
            
            TxtBx_FileName.Text = _UserPreferences.ExportFileName;
            CB_FileType.Text = _UserPreferences.ExportFileType;
        }

        private void UpdateColorButtons ()
        {
            foreach (object control in flowLayoutPanel1.Controls)
            {
                if (control is Button button)
                {
                    for (int i = 0; i < Enum.GetNames (typeof (MapTypes)).Length; i++)
                    {
                        var mapType = (MapTypes)i;

                        if ((string)button.Tag == mapType.ToString ())
                        {
                            button.BackColor = _Maps[mapType].BackgroundColor;
                        }
                    }
                }
            }
        }

        private void B_Source_Folder_Button_Click (object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                // Set validate names and check file exists to false otherwise windows will
                // not let you select "Folder Selection."
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                Title = "Source Folder Select",
                InitialDirectory = _UserPreferences.SourceFolder,
                FileName = "Select Folder"
            };

            if (fileDialog.ShowDialog () == DialogResult.OK)
            {
                _UserPreferences.SourceFolder = Path.GetDirectoryName (fileDialog.FileName);
                CheckFolderFiles (_UserPreferences.SourceFolder);
            }
        }

        private bool FolderIsEmpty (string folder)
        {
            string[] files = GetFiles (folder);

            foreach (KeyValuePair<MapTypes, Map> map in _Maps)
            {
                string[] images = GetFilesWithSuffix (map.Value.Suffixes, files);

                if (images != null)
                {
                    return false;
                }
            }

            return true;
        }

        private void CheckFolderFiles (string folder)
        {
            string[] files = GetFiles (folder);
            ClearAppSelection ();

            if (files.Length == 0)
                return;

            // Loop through every map type.
            foreach (KeyValuePair<MapTypes, Map> map in _Maps)
            {
                PreselectImagesFromFolder (map, files);
            }
        }

        private void ClearAppSelection ()
        {
            // Reset all map selections in the client.
            foreach (KeyValuePair<MapTypes, Map> map in _Maps)
            {
                map.Value.IsSelected = false;
                var checkBox = GetCheckBoxFromMapType (map.Key);

                if (checkBox != null)
                    checkBox.Checked = false;
            }

            _MapSegments.Clear ();
            B_MapOrder.Enabled = false;
        }

        private void PreselectImagesFromFolder (KeyValuePair<MapTypes, Map> map, string[] files)
        {
            // Determine if the map type is in the current image list by filtering if it's suffix can be found.
            string[] images = GetFilesWithSuffix (map.Value.Suffixes, files);

            //_MapSegments.Clear ();
            // If it's suffix can be found then perform more logic as it's in the folder.
            if (images != null)
            {
                // Grab all images for each map type.
                _MapSegments.Add (map.Key, images);
                // Enable map order button as images have been selected.
                B_MapOrder.Enabled = true;

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
            var fileDialog = new OpenFileDialog
            {
                // Set validate names and check file exists to false otherwise windows will
                // not let you select "Folder Selection."
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                Title = "Destination Folder Select",
                InitialDirectory = _UserPreferences.DestinationFolder,
                FileName = "Select Folder"
            };

            if (fileDialog.ShowDialog () == DialogResult.OK)
            {
                _UserPreferences.DestinationFolder = Path.GetDirectoryName (fileDialog.FileName);
            }
        }

        private void B_Combine_Images_Click (object sender, EventArgs e)
        {
            if (FolderIsEmpty (_UserPreferences.SourceFolder))
            {
                string caption = "No Images found!";
                string message = "There are no compatible images within the folder to combine. Please select a folder with compatible images or add new file suffixes through the preferences menu.";

                MessageBox.Show (message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Directory.Exists (_UserPreferences.DestinationFolder) == false)
            {
                string caption = "No Destination Chosen!";
                string message = "There is no destination folder chosen. Please choose a destination to place the combined images.";

                MessageBox.Show (message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _Worker.RunWorkerAsync ();
            B_Combine_Images.Enabled = false;
        }

        private void StartThread ()
        {
            backgroundWorker1.RunWorkerAsync ();
        }

        private void CombineImagesAsync (object sender, DoWorkEventArgs e)
        {
            string[] files = GetFiles (_UserPreferences.SourceFolder);
            var worker = (BackgroundWorker)sender;

            if (files.Length == 0)
                return;

            // Possibly make it so it's not a foreach loop and go through each map seperately so that memory gets flushed between each map type.
            // Possibly consider putting it through a secondary form window which opens per map being made and then closes so as to flush the memory.
            foreach (KeyValuePair<MapTypes, Map> map in _Maps)
            {
                if (map.Value.IsSelected)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        CreateMap (files, map.Key, map.Value, worker).GetAwaiter ();
                    }
                }
            }
        }

        private async Task CreateMap (string[] files, MapTypes mapType, Map map, BackgroundWorker worker)
        {
            Console.WriteLine (mapType.ToString () + ": Working");
            var startTime = DateTime.Now;
            worker.ReportProgress (0, mapType.ToString () + ": Working");

            CreateCombinedImageMap (mapType, map, files);

            var doneTime = DateTime.Now;
            var span = (startTime - doneTime);

            Console.WriteLine (mapType.ToString () + ": Done - Time: " + span.ToString(@"hh\:mm\:ss\.ff") + "\n");
            worker.ReportProgress (100, mapType.ToString () + ": Done - Time: " + span.ToString (@"hh\:mm\:ss\.ff") + "\n");

            GC.Collect ();
            await Task.Delay (2000);
            GC.Collect ();

            //Console.WriteLine (mapType.ToString () + ": Collected");
        }

        private void worker_ProgressChanged (object sender, ProgressChangedEventArgs e)
        {
            Lbl_ConsoleText.Text += e.UserState.ToString () + "\n";
        }

        private void worker_RunWorkerCompleted (object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes. 
            // This method runs on the main thread.
            if (e.Error != null)
                MessageBox.Show ("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show ("Image Combining Cancelled.");
            else
                MessageBox.Show ("Finished Combining Images");

            B_Combine_Images.Enabled = true;
        }

        /// <summary>
        /// Find and returns any image file types found within the source folder.
        /// </summary>
        /// <returns></returns>
        private string[] GetFiles (string folder)
        {
            string[] extensions = new[] { ".jpeg", ".jpg", ".png", ".tga", ".tiff" };

            if (Directory.Exists (folder))
            {
                string[] files = Directory
                .GetFiles (folder)
                .Where (file => extensions.Any (file.ToLower ().EndsWith))
                .ToArray ();

                return files;
            }

            return new string[0];
        }

        private void CreateCombinedImageMap (MapTypes mapType, Map map, string[] files)
        {
            //string[] images = GetFilesWithSuffix (map.Suffixes, files);
            string[] images = _MapSegments[mapType];
            string mapName = _UserPreferences.ExportFileName + map.OutputSuffix + _UserPreferences.ExportFileType;

            if (images != null && Directory.Exists (_UserPreferences.DestinationFolder))
            {
                _ImageCombiner = new ImageCombiner ();
                _ImageCombiner.CombineImages (images[0], images.ToArray (), _UserPreferences.DestinationFolder, mapName, map.BackgroundColor);
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

        private void SetupCheckBoxEvents ()
        {
            CB_BaseColor.CheckedChanged += ChB_CheckedChanged;
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

        private void SetupButtonClickEvents ()
        {
            B_BaseColorPicker.Click += B_ColorPicker_Click;
            B_BaseColorPicker.MouseDown += B_ColorPicker_MouseDown;

            B_RoughnessPicker.Click += B_ColorPicker_Click;
            B_RoughnessPicker.MouseDown += B_ColorPicker_MouseDown;

            B_MetallicPicker.Click += B_ColorPicker_Click;
            B_MetallicPicker.MouseDown += B_ColorPicker_MouseDown;

            B_AmbientOcclusionPicker.Click += B_ColorPicker_Click;
            B_AmbientOcclusionPicker.MouseDown += B_ColorPicker_MouseDown;

            B_IORPicker.Click += B_ColorPicker_Click;
            B_IORPicker.MouseDown += B_ColorPicker_MouseDown;

            B_NormalPicker.Click += B_ColorPicker_Click;
            B_NormalPicker.MouseDown += B_ColorPicker_MouseDown;

            B_NormalDXPicker.Click += B_ColorPicker_Click;
            B_NormalDXPicker.MouseDown += B_ColorPicker_MouseDown;

            B_HeightPicker.Click += B_ColorPicker_Click;
            B_HeightPicker.MouseDown += B_ColorPicker_MouseDown;

            B_EmissivePicker.Click += B_ColorPicker_Click;
            B_EmissivePicker.MouseDown += B_ColorPicker_MouseDown;

            B_DiffusePicker.Click += B_ColorPicker_Click;
            B_DiffusePicker.MouseDown += B_ColorPicker_MouseDown;

            B_SpecularPicker.Click += B_ColorPicker_Click;
            B_SpecularPicker.MouseDown += B_ColorPicker_MouseDown;

            B_GlossinessPicker.Click += B_ColorPicker_Click;
            B_GlossinessPicker.MouseDown += B_ColorPicker_MouseDown;

            B_ReflectionPicker.Click += B_ColorPicker_Click;
            B_ReflectionPicker.MouseDown += B_ColorPicker_MouseDown;
        }

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

        private void ResetColorToDefault (Button button, Map map)
        {
            map.BackgroundColor = map.DefaultBackgroundColor;
            button.BackColor = map.DefaultBackgroundColor;
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
                        _Maps[mapType].IsSelected = checkBox.Checked;
                    }
                }
            }
        }

        private void B_ColorPicker_Click (object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    string tag = (string)button.Tag;

                    if (Enum.TryParse (tag, out MapTypes mapType))
                    {
                        _Maps[mapType].BackgroundColor = GetBackgroundColor (button);
                    }
                }
            }
        }

        private void B_ColorPicker_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (sender is Button button)
                {
                    string tag = (string)button.Tag;

                    if (Enum.TryParse (tag, out MapTypes mapType))
                    {
                        var map = _UserPreferences.GetMap (mapType);
                        ResetColorToDefault (sender as Button, map);
                    }
                }
            }
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

        private void TSMI_Preferences_Click (object sender, EventArgs e)
        {
            var preferenceWindow = new Preferences_Window (_UserPreferences);
            preferenceWindow.ShowDialog (this);
        }

        private void MainWindow_FormClosing (object sender, FormClosingEventArgs e)
        {
            SavePreferences ();
        }

        private void SavePreferences ()
        {
            string json = UserPreferences.GetJSON (_UserPreferences);
            File.WriteAllText (_PreferenceFileLocation, json);
        }

        private void B_MapOrder_Click (object sender, EventArgs e)
        {
            var mapOrder = new Map_Order (_MapSegments, _UserPreferences);
            mapOrder.ShowDialog (this);
        }

        private void clearToolStripMenuItem_Click (object sender, EventArgs e)
        {
            ClearAppSelection ();
        }
    }
}
