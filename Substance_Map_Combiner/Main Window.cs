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
        private string _SourceImage = @"J:\Substance Painter Files\Substance Exports\Giant Mech\Giant Mech Maps\Giant Mech Body\New folder\B_Bot_Shell_Ambient_occlusion.png";
        private string _SourceFolder = @"J:\Substance Painter Files\Substance Exports\Giant Mech\Giant Mech Maps\Giant Mech Body\New folder";
        private string _DestinationFolder = @"J:\Substance Painter Files\Substance Exports\Giant Mech\Giant Mech Maps\Giant Mech Body\New folder";
        private List<string> _OverlayImages = new List<string> ();

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

        private void B_Combine_Images_Click (object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles (_SourceFolder, "*.png");

            foreach (string file in files)
            {
                if (file.Contains ("_Ambient_occlusion"))
                    _OverlayImages.Add (file);
            }

            ImageCombiner.CombineImages (_SourceImage, _OverlayImages.ToArray (), _DestinationFolder, "AO.png");
        }
    }
}
