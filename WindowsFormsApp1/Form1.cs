using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Accord.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.DataSets;
using Accord.Imaging.Filters;
using Shipwreck.Phash;
using Shipwreck.Phash.Bitmaps;
using Accord;
using Accord.Math;
using System.Drawing.Imaging;

namespace SpecialTopicsFinals
{
    public partial class SpecialTopicsFinals : Form
    {

        private IntPoint[] harrisPoints1;
        private IntPoint[] harrisPoints2;

        private IntPoint[] correlationPoints1;
        private IntPoint[] correlationPoints2;

        public SpecialTopicsFinals()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sourcebox.SizeMode = PictureBoxSizeMode.Zoom;
            source2box.SizeMode = PictureBoxSizeMode.Zoom;
            resultbox.SizeMode = PictureBoxSizeMode.Zoom;


            TestImages t = new TestImages();

            //string path_earl = System.IO.Path.GetFullPath(@"../../earl.png");
            //string path_janre1 = System.IO.Path.GetFullPath(@"../../janre1.png");

            string path_earl = System.IO.Path.GetFullPath(@"../../janre1.png");
            string path_janre1 = System.IO.Path.GetFullPath(@"../../janre2.png");
            //string path_janre1 = System.IO.Path.GetFullPath(@"../../car1.png");
            //string path_janre1 = System.IO.Path.GetFullPath(@"../../nokia1.png");

            /*
            var bitmap = (Bitmap)Accord.Imaging.Image.FromFile(path_earl);
            var bitmap1 = new Bitmap(path_earl);
            var bitmap2 = new Bitmap(path_janre1);
            var hash1 = ImagePhash.ComputeDigest(bitmap1.ToLuminanceImage());
            var hash2 = ImagePhash.ComputeDigest(bitmap2.ToLuminanceImage());
            var score = ImagePhash.GetCrossCorrelation(hash1, hash2);
            */


            var bitmap1 = new Bitmap(path_earl);
            var bitmap2 = new Bitmap(path_janre1);

            /*
            HarrisCornersDetector harris = new HarrisCornersDetector(
                HarrisCornerMeasure.Harris, 20000f, 1.4f, 5);
            harrisPoints1 = harris.ProcessImage(bitmap1).ToArray();
            harrisPoints2 = harris.ProcessImage(bitmap2).ToArray();

            CorrelationMatching matcher = new CorrelationMatching(9, bitmap1, bitmap2);
            IntPoint[][] matches = matcher.Match(harrisPoints1, harrisPoints2);

            // Get the two sets of points
            correlationPoints1 = matches[0];
            correlationPoints2 = matches[1];

            // Concatenate the two images in a single image (just to show on screen)
            Concatenate concat = new Concatenate(bitmap1);
            Bitmap img3 = concat.Apply(bitmap2);

            // Show the marked correlations in the concatenated image
            PairsMarker pairs = new PairsMarker(
                correlationPoints1, // Add image1's width to the X points to show the markings correctly
                correlationPoints2.Apply(p => new IntPoint(p.X + bitmap1.Width, p.Y)));

            resultbox.Image = pairs.Apply(img3);

            //System.Console.Write("score: " + score);
            */


            /*
            // create template matching algorithm's instance
            // use zero similarity to make sure algorithm will provide anything
            ExhaustiveTemplateMatching tm = new ExhaustiveTemplateMatching(0);

            // compare two images
            TemplateMatch[] matchings = tm.ProcessImage(bitmap1, bitmap2);

            // check similarity level
            if (matchings[0].Similarity > 0.95f)
            {
                // do something with quite similar images
            }
            */

            /*
            source2box.Image = bitmap1;
            sourcebox.Image = bitmap2;

            // create template matching algorithm's instance
            var tm = new ExhaustiveTemplateMatching(0);

            // find all matchings with specified above similarity
            TemplateMatch[] matchings = tm.ProcessImage(bitmap2, bitmap1);

            // highlight found matchings
            BitmapData data = bitmap2.LockBits(ImageLockMode.ReadWrite);

            foreach (TemplateMatch m in matchings)
            {
                Drawing.Rectangle(data, m.Rectangle, Color.Red);
                // do something else with the matching
            }

            bitmap2.UnlockBits(data);
            resultbox.Image = bitmap2;
            */

            TemplateMatch[] matchings;
            float similarityMax = 0f;
            float threshold = 0.925f;
            ExhaustiveTemplateMatching exhaustiveTemplateMatching = new ExhaustiveTemplateMatching(threshold);
            matchings = exhaustiveTemplateMatching.ProcessImage(bitmap2, bitmap1);
            BitmapData data = bitmap2.LockBits(
                            new Rectangle(0, 0, bitmap2.Width, bitmap2.Height),
                            ImageLockMode.ReadWrite, bitmap2.PixelFormat);
            foreach (TemplateMatch m in matchings)
            {
                Drawing.Rectangle(data, m.Rectangle, Color.Red); // Adding rectangles in the areas of possible matches
                                                                 // do something else with matching
                if (m.Similarity > similarityMax)
                {
                    similarityMax = m.Similarity;
                }
            }
            bitmap2.UnlockBits(data);
            //bitmap2.Save("SourceImage_Processed.bmp", ImageFormat.Bmp); //Saving the image.
            resultbox.Image = bitmap2;

        }
    }
}
