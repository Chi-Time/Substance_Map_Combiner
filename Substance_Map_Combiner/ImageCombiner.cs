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
        public void CombineImages (string baseImage, string[] overlayImages, string outputPath, string outputName, Color backgroundColor)
        {
            using (var inStream = new MemoryStream (File.ReadAllBytes (baseImage)))
            {
                using (var outStream = new MemoryStream ())
                {
                    using (var imageFactor = new ImageFactory (preserveExifData: false))
                    {
                        imageFactor.Load (baseImage);
                        imageFactor.BackgroundColor (backgroundColor);

                        for (int i = 0; i < overlayImages.Length; i++)
                        {
                            var imageLayer = new ImageLayer
                            {
                                Image = Image.FromFile (overlayImages[i])
                            };

                            imageFactor.Overlay (imageLayer);
                        }

                        imageFactor.Save (outputPath + @"\" + outputName);
                    }
                }
            }
        }
    }
}
