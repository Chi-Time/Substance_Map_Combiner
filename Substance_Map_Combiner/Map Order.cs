using System;
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
    public partial class Map_Order : Form
    {
        private MainWindow _Caller = null;
        private List<string> _Maps = new List<string> ();
        private UserPreferences _UserPreferences = null;
        private Dictionary<MapTypes, Map> _MapsYeah = null;
        private Dictionary<MapTypes, string[]> _MapSegments = null;

        public Map_Order (MainWindow caller, List<string> maps)
        {
            InitializeComponent ();

            _Caller = caller;
            _Maps = maps;
        }

        public Map_Order (MainWindow caller, Dictionary<MapTypes, string[]> maps, Dictionary<MapTypes, Map> mapsYeah, UserPreferences userPreferences)
        {
            InitializeComponent ();

            _Caller = caller;
            _MapsYeah = mapsYeah;
            _MapSegments = maps;
            _UserPreferences = userPreferences;

            InitialiseUI ();
        }

        private void InitialiseUI ()
        {
            PopulateDropDown ();
        }

        private void PopulateDropDown ()
        {
            foreach (KeyValuePair<MapTypes, string[]> map in _MapSegments)
            {
                CB_MapTypes.Items.Add (map.Key.ToString ());
            }
        }

        private void Map_Order_Load (object sender, EventArgs e)
        {
            var firstElememt = _MapSegments.First ();
            DisplayMapList (firstElememt.Value);
            CB_MapTypes.Text = firstElememt.Key.ToString ();
            //string[] fileTypes = new string[] { ".jpe", ".bmp", ".rle", ".dds", ".dib", "pxr", "pns", ".jpg", ".jpeg", ".png", ".tga", ".tiff", ".tif", ".gif"};

            ////TODO: Don't rely on base-color as it may not be present for some map combinations. 
            //// Try instead to find the map type with the highest amount of images within it.
            //foreach (string image in _MapSegments[MapTypes.BaseColor])
            //{
            //    // Remove filepath from name and trailing backslash.
            //    var imageName = image.Replace (_UserPreferences.SourceFolder, "");
            //    imageName = imageName.Remove (0, 1);
                
            //    // Remove whatever possible suffix the user has for their map types.
            //    foreach (string suffix in _MapsYeah[MapTypes.BaseColor].Suffixes)
            //    {
            //        imageName = imageName.Replace (suffix, "");
            //    }

            //    // Remove what the original filetype is from the string.
            //    foreach (string fileType in fileTypes)
            //    {
            //        imageName = imageName.Replace (fileType, "");
            //    }

            //    // Add these images to the list for ordering.
            //    LBX_MapOrder.Items.Add (imageName);
            //}
        }

        //TODO: Better understand and document what this is doing - https://stackoverflow.com/questions/805165/reorder-a-winforms-listbox-using-drag-and-drop
        private void LBX_MapOrder_DragDrop (object sender, DragEventArgs e)
        {
            var point = LBX_MapOrder.PointToClient (new Point (e.X, e.Y));
            int index = LBX_MapOrder.IndexFromPoint (point);
            if (index < 0) index = LBX_MapOrder.Items.Count - 1;
            object data = e.Data.GetData (typeof (string));
            LBX_MapOrder.Items.Remove (data);
            LBX_MapOrder.Items.Insert (index, data);
            ReorderMaps ();
        }

        private void LBX_MapOrder_DragOver (object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void LBX_MapOrder_MouseDown (object sender, MouseEventArgs e)
        {
            if (LBX_MapOrder.SelectedItem == null) return;
            LBX_MapOrder.DoDragDrop (LBX_MapOrder.SelectedItem, DragDropEffects.Move);
        }

        private void B_Accept_Click (object sender, EventArgs e)
        {
            //foreach (var thing in _Maps)
            //{
            //    Console.WriteLine ("Thing: " + thing);
            //}

            //foreach (KeyValuePair<MapTypes, string[]> map in _MapSegments)
            //{
            //    var indexes = new List<int> ();

            //    foreach (string image in map.Value)
            //    {
            //        for (int i = 0; i < _Maps.Count; i++)
            //        {
            //            if (image.Contains (_Maps[i]))
            //            {
            //                indexes.Add (i);
            //                //Console.WriteLine (image + " | " + _Maps[i]);
            //            }
            //        }
            //    }

            //    Console.WriteLine ($"REORDERING: {map.Key.ToString ()} \n \n \n");

            //    reorder (map.Value, indexes.ToArray ());

            //    foreach (string image in map.Value)
            //    {
            //        Console.WriteLine (image);
            //    }
            //}

            this.Close ();
        }

        private void ReorderMaps ()
        {
            // Clear the list of ordered maps.
            _Maps.Clear ();

            // Get the current ordering of maps from the list.
            foreach (var item in LBX_MapOrder.Items)
            {
                _Maps.Add (item.ToString ());
            }

            foreach (var thing in _Maps)
            {
                Console.WriteLine ("Thing: " + thing);
            }

            // Loop through every maptype.
            foreach (KeyValuePair<MapTypes, string[]> map in _MapSegments)
            {
                // Get ready to store an index orders that may have changed.
                var indexes = new List<int> ();

                // Loop through every image for the current map type.
                foreach (string image in map.Value)
                {
                    // Loop through the current ordered items.
                    for (int i = 0; i < _Maps.Count; i++)
                    {
                        // If our current image is the same as the ordered imaged then store it's current index order so that we can re-order it later.
                        if (image.Contains (_Maps[i]))
                        {
                            indexes.Add (i);
                        }
                    }
                }

                Console.WriteLine ($"----REORDERING: {map.Key.ToString ()}---- \n \n \n");

                // If the current maptype has found an index order that's changed then re-order all of the images in the current maptype by those found.
                if (indexes.Count > 0)
                    OrderByGivenIndexes (map.Value, indexes.ToArray ());

                foreach (string image in map.Value)
                {
                    Console.WriteLine (image);
                }

                Console.WriteLine ("\n \n \n");
            }
        }

        // Method to reorder elements of arr[] according 
        // to index[] 
        private void OrderByGivenIndexes (string[] arr, int[] indexes)
        {
            if (arr.Length < _Maps.Count)
                return;

            string[] temp = new string[arr.Length];

            // arr[i] should be present at index[i] index 
            for (int i = 0; i < arr.Length; i++)
                temp[indexes[i]] = arr[i];

            // Copy temp[] to arr[] 
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = temp[i];
                indexes[i] = i;
            }
        }


        private void B_Cancel_Click (object sender, EventArgs e)
        {
            this.Close ();
        }

        private void CB_MapTypes_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                if (comboBox != null)
                {
                    // Grab the current selection in the dropdown and then find the relevent maptype it relates to.
                    string selection = comboBox.Text;

                    foreach (KeyValuePair<MapTypes, string[]> map in _MapSegments)
                    {
                        // Display the map list for the current map type selected in the drop-down.
                        if (selection == map.Key.ToString ())
                        {
                            DisplayMapList (map.Value);
                        }
                    }
                }
            }
        }

        private void DisplayMapList (string[] images)
        {
            // Clear the list for new data.
            LBX_MapOrder.Items.Clear ();

            foreach (string image in images)
            {
                // Remove filepath from name and trailing backslash.
                string imageName = image.Replace (_UserPreferences.SourceFolder, "");
                imageName = imageName.Remove (0, 1);

                // Add these images to the list for ordering.
                LBX_MapOrder.Items.Add (imageName);
            }
        }
    }
}

/*
 * Foreach map segment.
 * Check if the current segment matches with the given one.
 * If it does, note the index.
 * Apply this new index order to all of the maps.
 */