using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Substance_Map_Combiner
{
    //TODO: Stop application from crashing when user has cleared all maps but clicks map order. Maybe disable map order button until there are items selected.
    public partial class Map_Order : Form
    {
        private UserPreferences _UserPreferences = null;
        private List<string> _Maps = new List<string> ();
        private Dictionary<MapTypes, string[]> _MapSegments = null;

        public Map_Order (Dictionary<MapTypes, string[]> maps, UserPreferences userPreferences)
        {
            InitializeComponent ();

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