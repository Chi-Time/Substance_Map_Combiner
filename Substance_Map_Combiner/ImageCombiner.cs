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
        //public void CombineImages (string baseImage, string[] overlayImages, string outputPath, string outputName)
        //{
        //    using (MemoryStream inStream = new MemoryStream (File.ReadAllBytes (baseImage)))
        //    {
        //        using (MemoryStream outStream = new MemoryStream ())
        //        {
        //            using (var imageFactor = new ImageFactory (preserveExifData: true))
        //            {
        //                var imageLayer = new ImageLayer ();
        //                var loadedImage = imageFactor.Load (baseImage);

        //                for (int i = 0; i < overlayImages.Length; i++)
        //                {
        //                    imageLayer.Image = System.Drawing.Image.FromFile (overlayImages[i]);
        //                    loadedImage.Overlay (imageLayer);
        //                }

        //                loadedImage.Save (outputPath + @"\" + outputName);
        //                loadedImage.Dispose ();
        //                imageFactor.Dispose ();
        //            }
        //        }
        //    }
        //}

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

        //public void CombineImages (string baseImage, string[] overlayImages, string outputPath, string outputName, Color backgroundColor)
        //{
        //    using (var inStream = new MemoryStream (File.ReadAllBytes (baseImage)))
        //    {
        //        using (var outStream = new MemoryStream ())
        //        {
        //            var backgroundImage = Image.FromFile (baseImage);
        //            var image = new Bitmap (backgroundImage.Width, backgroundImage.Height);

        //            using (var gr = Graphics.FromImage (image))
        //            {
        //                gr.DrawImage (backgroundImage, new Point (0, 0));
        //            }

        //            for (int i = 0; i < overlayImages.Length; i++)
        //            {
        //                var overlayImage = Image.FromFile (overlayImages[i]);

        //                using (var gr = Graphics.FromImage (image))
        //                {
        //                    gr.DrawImage (overlayImage, new Point (0, 0));
        //                }
        //            }

        //            image.Save (outputPath + @"\" + outputName);


        //            using (var imageFactor = new ImageFactory (preserveExifData: false))
        //            {
        //                imageFactor.Load (baseImage);

        //                for (int i = 0; i < overlayImages.Length; i++)
        //                {
        //                    var imageLayer = new ImageLayer
        //                    {
        //                        Image = Image.FromFile (overlayImages[i])
        //                    };

        //                    imageFactor.Overlay (imageLayer);
        //                }

        //                //var loadedImage = imageFactor.Load (baseImage);
        //                //loadedImage.BackgroundColor (backgroundColor);

        //                //for (int i = 0; i < overlayImages.Length; i++)
        //                //{
        //                //    imageLayer.Image = System.Drawing.Image.FromFile (overlayImages[i]);
        //                //    loadedImage.Overlay (imageLayer);
        //                //}

        //                imageFactor.Save (outputPath + @"\" + outputName);
        //            }
        //        }
        //    }
        //}
    }
}
