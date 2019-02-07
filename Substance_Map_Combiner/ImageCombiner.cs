using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using ImageProcessor.Imaging;
using System.Drawing;

namespace Substance_Map_Combiner
{
    public class ImageCombiner
    {
        public static void CombineImages (string baseImage, string[] overlayImages, string outputPath, string outputName)
        {
            using (var imageFactor = new ImageFactory (preserveExifData: true))
            {
                var imageLayer = new ImageLayer ();
                var loadedImage = imageFactor.Load (baseImage);

                for (int i = 0; i < overlayImages.Length; i++)
                {
                    imageLayer.Image = System.Drawing.Image.FromFile (overlayImages[i]);
                    loadedImage.Overlay (imageLayer);
                }

                loadedImage.Save (outputPath + @"\" + outputName);
            }
        }

        public static void CombineImages (string baseImage, string[] overlayImages, string outputPath, string outputName, Color color)
        {
            using (var imageFactor = new ImageFactory (preserveExifData: true))
            {
                var imageLayer = new ImageLayer ();
                var loadedImage = imageFactor.Load (baseImage);
                loadedImage.BackgroundColor (color);

                for (int i = 0; i < overlayImages.Length; i++)
                {
                    imageLayer.Image = System.Drawing.Image.FromFile (overlayImages[i]);
                    loadedImage.Overlay (imageLayer);
                }

                loadedImage.Save (outputPath + @"\" + outputName);
            }
        }
    }
}
