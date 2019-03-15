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
        private List<string> _Maps = null;

        public Map_Order (MainWindow caller, List<string> maps)
        {
            InitializeComponent ();

            _Caller = caller;
            _Maps = maps;
        }

        private void Map_Order_Load (object sender, EventArgs e)
        {
            foreach (var map in _Maps)
            {
                LBX_MapOrder.Items.Add (map);
            }
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
            _Maps.Clear ();
            foreach (var item in LBX_MapOrder.Items)
            {
                _Maps.Add (item.ToString ());
            }

            foreach (var thing in _Maps)
            {
                Console.WriteLine ("Thing: " + thing);
            }

            this.Close ();
        }

        private void B_Cancel_Click (object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}
