using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.XImgproc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tensorflow.NumPy;

namespace LogoRecognitionSystem
{
    public static class ImageHelper
    {

        public static Bitmap BlackWhiteFilter(Bitmap img)=> img.ToImage<Bgr, Byte>().SmoothGaussian(5).Convert<Gray, Byte>().ThresholdBinaryInv(new Gray(220), new Gray(250)).ToBitmap();
        public static Bitmap BGRFiler(Bitmap bmp) => bmp.ToImage<Bgr, byte>().ToBitmap();
        public static Bitmap GrayFilter(Bitmap bmp) => bmp.ToImage<Gray, byte>().ToBitmap();
        public static Bitmap CutImage(Rectangle rect, Image<Bgr, byte> Img)
        {

            Img.ROI = rect;

            Image<Bgr, byte> temp = Img.CopyBlank();

            Img.CopyTo(temp);

            Img.ROI = Rectangle.Empty;

            return temp.ToBitmap();

        }


        public static Bitmap CutImage(Rectangle rect, Bitmap bmp)
        {
            Image<Bgr, byte> Img = bmp.ToImage<Bgr, byte>();
           
            Img.ROI = rect;

            Image<Bgr, byte> temp = Img.CopyBlank();

            Img.CopyTo(temp);

            Img.ROI = Rectangle.Empty;

            return temp.ToBitmap();

        }

        public static Bitmap ResizeImage(int wid,int hei, Image<Bgr, byte> Img)
        {

            return Img.Resize(wid, hei, Emgu.CV.CvEnum.Inter.Linear).ToBitmap();

        }

        public static Bitmap ResizeImage(int wid, int hei,Bitmap Img)
        {

            return Img.ToImage<Bgr, byte>().Resize(wid, hei, Emgu.CV.CvEnum.Inter.Linear).ToBitmap();

        }

        public static List<Rectangle> Selectivesearch(Bitmap bmp,int base_K,int increment_k ,int minwidth, int minheight, int maxwidth, int maxheight)
        {

            Image<Bgr, byte> img = bmp.ToImage<Bgr, byte>();
            SelectiveSearchSegmentation ss = new SelectiveSearchSegmentation();

            ss.SetBaseImage(img);

            ss.SwitchToSelectiveSearchQuality(base_K, increment_k, 0.5f);
          
            return ss.Process().ToList().Where(x => ((x.Width > minwidth) && (x.Height > minheight) && (x.Width < maxwidth) && (x.Height < maxheight))).ToList();

        }

        public static int[,,] getPixels(Bitmap image)
        {

            int[,,] pixels = new int[image.Width, image.Height, 3];



            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {

                    Color pixel = image.GetPixel(i, j);

                    pixels[i, j, 0] = pixel.R;
                    pixels[i, j, 1] = pixel.G;
                    pixels[i, j, 2] = pixel.B;

                }

            }

            return pixels;

        }

        public static NDArray ImagesToNDArray(List<TrainingSet> bitmaps, int width, int height)
        {

            int[,,,] imagespixels = new int[bitmaps.Count, width, height, 3];

            for (int bi = 0; bi < bitmaps.Count; bi++)
            {

                Bitmap bitmap = bitmaps[bi].Image;

                int[,,] pixels = getPixels(bitmap);

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {

                        for (int z = 0; z < 3; z++)
                        {

                            imagespixels[bi, x, y, z] = pixels[x, y, z];


                        }

                    }


                }


            }

            return np.array(imagespixels);


        }


        public static NDArray ImageToNDArray(Bitmap bitmap)
        {

            int[,,,] imagespixels = new int[1, bitmap.Width, bitmap.Height, 3];

            for (int bi = 0; bi < 1; bi++)
            {

                int[,,] pixels = getPixels(bitmap);

                for (int x = 0; x < bitmap.Width; x++)
                {
                    for (int y = 0; y < bitmap.Width; y++)
                    {

                        for (int z = 0; z < 3; z++)
                        {

                            imagespixels[bi, x, y, z] = pixels[x, y, z];


                        }

                    }


                }


            }

            return np.array(imagespixels);


        }

        public static NDArray IdelaValuesToNDArray(List<TrainingSet> images,int outputCount)
        {

            int[,] idealvalues = new int[images.Count, outputCount];

            for (int i = 0; i < images.Count; i++)
            {
                for (int j = 0; j < outputCount; j++)
                {

                    if (j == images[i].Match)
                        idealvalues[i, j] = 1;

                    else idealvalues[i, j] = 0;

                }

            }


            return np.array(idealvalues);

        }

        public static List<BLob> ExtractBlobsFromImage(Bitmap Image)
        {

            Bitmap image = new Bitmap(Image);

            List<Rectangle> selectedBlobs = Selectivesearch(image, Central_Static_Value.Settings.base_k_, Central_Static_Value.Settings.Increment_k, Central_Static_Value.Settings.Img_Minimal_Width, Central_Static_Value.Settings.Img_Minimal_Height, Central_Static_Value.Settings.Img_Maximal_Width, Central_Static_Value.Settings.Img_Maximal_Height);

            return selectedBlobs.Select(x =>
            {
                Bitmap img = CutImage(x, new Bitmap(Image));

                switch (Central_Static_Value.Settings.Filter)
                {

                    case "Colored": img = BGRFiler(img); break;
                    case "Gray": img = GrayFilter(img); break;
                    case "BlackWeight": img = BlackWhiteFilter(img); break;
                    default: img = BGRFiler(img); break;



                }

                return new BLob(img,x);
            }

            ).ToList();

        }

    }
}
