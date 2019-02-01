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
    public partial class MainWindow : Form
    {
        private string _SourceFolder = "";
        private string _DestinationFolder = "";

        public MainWindow ()
        {
            InitializeComponent ();
        }

        private void Main_Window_Load (object sender, EventArgs e)
        {

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
    }
}
