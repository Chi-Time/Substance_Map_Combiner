using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Substance_Map_Combiner
{
    //TODO: Fill drop-down dynamically by reading from map types and preferences look at map order's implementation.
    public partial class Preferences_Window : Form
    {
        private UserPreferences _UserPrefences = null;
        private MapTypes _CurrentMapType = MapTypes.BaseColor;

        public Preferences_Window (UserPreferences userPreferences)
        {
            InitializeComponent ();
            _UserPrefences = userPreferences;

            InitialiseSuffixList ();
        }

        private void InitialiseSuffixList ()
        {
            CmBx_SuffixType.Text = "Base Color";
            TxtBx_Suffixes.Text = GetSuffixes (_UserPrefences.Maps[MapTypes.BaseColor].Suffixes);
            TxtBx_OutputSuffix.Text = _UserPrefences.GetMap (MapTypes.BaseColor).OutputSuffix;
        }

        private void Preferences_Window_Load (object sender, EventArgs e)
        {

        }

        private void TxtBx_Suffixes_TextChanged (object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox != null)
                {
                    var map = _UserPrefences.GetMap (_CurrentMapType);
                    UpdateSuffixes (map, textBox.Text);

                    // Ensure that there is always a default suffix to append to the end of files if the user has cleared the suffix list.
                    if (map.Suffixes.Count <= 0)
                    {
                        map.Suffixes.Add (map.DefaultSuffix);
                    }
                }
            }
        }

        private void UpdateSuffixes (Map map, string text)
        {
            string[] suffixes = text.Split (',');
            map.Suffixes.Clear ();

            foreach (string suffix in suffixes)
            {
                if (string.IsNullOrWhiteSpace (suffix) == false)
                    map.Suffixes.Add (suffix.Trim ());
            }
        }

        //TODO: Consider refactoring.
        private void CmBx_SuffixType_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                if (comboBox != null)
                {
                    string text = comboBox.Text;

                    if (IsSuffixType (text, "Base Color"))
                    {
                        _CurrentMapType = MapTypes.BaseColor;
                        UpdateTextBoxes ();
                    }

                    if (IsSuffixType (text, "Roughness"))
                    {
                        _CurrentMapType = MapTypes.Roughness;
                        UpdateTextBoxes ();
                    }

                    if (IsSuffixType (text, "Metallic"))
                    {
                        _CurrentMapType = MapTypes.Metallic;
                        UpdateTextBoxes ();
                    }

                    if (IsSuffixType (text, "AO"))
                    {
                        _CurrentMapType = MapTypes.AO;
                        UpdateTextBoxes ();
                    }

                    if (IsSuffixType (text, "IOR"))
                    {
                        _CurrentMapType = MapTypes.IOR;
                        UpdateTextBoxes ();
                    }

                    if (IsSuffixType (text, "Normal"))
                    {
                        _CurrentMapType = MapTypes.Normal;
                        UpdateTextBoxes ();
                    }

                    if (IsSuffixType (text, "NormalDX"))
                    {
                        _CurrentMapType = MapTypes.Normal_DirectX;
                        UpdateTextBoxes ();
                    }

                    if (IsSuffixType (text, "Height"))
                    {
                        _CurrentMapType = MapTypes.Height;
                        UpdateTextBoxes ();
                    }
                    

                    if (IsSuffixType (text, "Emissive"))
                    {
                        _CurrentMapType = MapTypes.Emissive;
                        UpdateTextBoxes ();
                    }

                    if (IsSuffixType (text, "Reflection"))
                    {
                        _CurrentMapType = MapTypes.Reflection;
                        UpdateTextBoxes ();
                    }

                    if (IsSuffixType (text, "Diffuse"))
                    {
                        _CurrentMapType = MapTypes.Diffuse;
                        UpdateTextBoxes ();
                    }

                    if (IsSuffixType (text, "Specular"))
                    {
                        _CurrentMapType = MapTypes.Specular;
                        UpdateTextBoxes ();
                    }

                    if (IsSuffixType (text, "Glossiness"))
                    {
                        _CurrentMapType = MapTypes.Glossiness;
                        UpdateTextBoxes ();
                    }
                }
            }
        }

        private bool IsSuffixType (string text, string suffixType)
        {
            if (text == suffixType)
                return true;

            return false;
        }

        private void UpdateTextBoxes ()
        {
            var map = _UserPrefences.GetMap (_CurrentMapType);
            TxtBx_Suffixes.Text = GetSuffixes (map.Suffixes);
            TxtBx_OutputSuffix.Text = map.OutputSuffix;
        }

        private string GetSuffixes (List<string> suffixes)
        {
            string suffixLine = "";

            foreach (string suffix in suffixes)
            {
                suffixLine += suffix + ", ";
            }

            return suffixLine;
        }

        private void TxtBx_OutputSuffix_TextChanged (object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox != null)
                {
                    var map = _UserPrefences.GetMap (_CurrentMapType);

                    // Ensure that if the user removes an output suffix that a default one is still retained.
                    if (string.IsNullOrWhiteSpace (textBox.Text))
                        map.OutputSuffix = map.DefaultSuffix;
                    else
                        map.OutputSuffix = textBox.Text;
                }
            }
        }

        private void B_Close_Click (object sender, EventArgs e)
        {
            //TODO: Close window without displaying message to user.
            this.Close ();
        }

        private void B_Reset_Click (object sender, EventArgs e)
        {
            //TODO: Make a reset to default's behaviour.
            foreach (KeyValuePair<MapTypes, Map> entry in _UserPrefences.Maps)
            {
                entry.Value.Suffixes.Clear ();
                entry.Value.Suffixes.Add (entry.Value.DefaultSuffix);
                entry.Value.OutputSuffix = entry.Value.DefaultSuffix;
            }
        }

        private void Preferences_Window_FormClosing (object sender, FormClosingEventArgs e)
        {
            //var window = MessageBox.Show ("Preference changes will be lost! Please click ok if you wish to close without saving any changes.", "Changes Will Be Lost!", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            //e.Cancel = (window == DialogResult.Cancel);
        }

        private void Preferences_Window_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close ();
        }
    }
}
