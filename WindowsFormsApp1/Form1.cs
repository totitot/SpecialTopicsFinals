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
using Accord.Math.Distances;
using Accord.Math;
using Accord;

namespace SpecialTopicsFinals
{
    public partial class SpecialTopicsFinals : Form
    {
        public SpecialTopicsFinals()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sourcebox1.SizeMode = PictureBoxSizeMode.Zoom;
            sourcebox2.SizeMode = PictureBoxSizeMode.Zoom;
            resultbox1.SizeMode = PictureBoxSizeMode.Zoom;
            resultbox2.SizeMode = PictureBoxSizeMode.Zoom;
            
            TestImages t = new TestImages();

            string path_earl = System.IO.Path.GetFullPath(@"../../janre1.png");
            string path_janre1 = System.IO.Path.GetFullPath(@"../../earl.png");

            var bitmap1 = new Bitmap(path_earl);
            var bitmap2 = new Bitmap(path_janre1);

            sourcebox1.Image = bitmap1;
            sourcebox2.Image = bitmap2;
        }

        private void sourcebox_btn_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "..\\..\\";
                openFileDialog1.FileName = "";
                DialogResult dr = openFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    //textBox1.Text = openFileDialog1.FileName;
                    //sourcebox.Load(openFileDialog1.FileName);
                    var bitmap = new Bitmap(openFileDialog1.FileName);
                    sourcebox1.Image = bitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.ToString());
            }
        }

        private void source2box_btn_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "..\\..\\";
                openFileDialog1.FileName = "";
                DialogResult dr = openFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    //textBox1.Text = openFileDialog1.FileName;
                    var bitmap = new Bitmap(openFileDialog1.FileName);
                    sourcebox2.Image = bitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.ToString());
            }
        }

        private void process_btn_Click(object sender, EventArgs e)
        {
            process1();
        }

        private void process1()
        {
            var bitmap1 = (Bitmap)sourcebox1.Image;
            var bitmap2 = (Bitmap)sourcebox2.Image;
            var hash1 = ImagePhash.ComputeDigest(bitmap1.ToLuminanceImage());
            var hash2 = ImagePhash.ComputeDigest(bitmap2.ToLuminanceImage());
            var score = ImagePhash.GetCrossCorrelation(hash1, hash2);

            Console.WriteLine("score: {0}", score);

            //threshold value
            var thres = new Threshold(110);

            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            // apply the filter to the model
            Bitmap grey1 = filter.Apply(bitmap1);
            thres.ApplyInPlace(grey1);
            
            // Apply the filter to the observed image
            Bitmap grey2 = filter.Apply(bitmap2);
            thres.ApplyInPlace(grey2);

            int modelPoints = 0, matchingPoints = 0;

            var skewChecker = new DocumentSkewChecker();
            var angle1 = skewChecker.GetSkewAngle(grey1);
            var rotationFilter1 = new RotateBicubic(-angle1);
            rotationFilter1.FillColor = Color.White;
            grey1 = rotationFilter1.Apply(grey1);

            var angle2 = skewChecker.GetSkewAngle(grey2);
            var rotationFilter2 = new RotateBicubic(-angle2);
            rotationFilter2.FillColor = Color.White;
            grey2 = rotationFilter2.Apply(grey2);

            //CorrelationMatching matcher = new CorrelationMatching(5, grey1, grey2);
            //var results = matcher.GetHashCode();
            var detector = new FastCornersDetector(15);
            var freak = new FastRetinaKeypointDetector(detector);
            FastRetinaKeypoint[] features1 = freak.Transform(grey1).ToArray();
            modelPoints = features1.Count();

            Console.WriteLine("count: {0}", modelPoints);

            FastRetinaKeypoint[] features2 = freak.Transform(grey2).ToArray();

            Console.WriteLine("count: {0}", features2.Count());

            KNearestNeighborMatching matcher = new KNearestNeighborMatching(7);
            //var length = 0;

            IntPoint[][] results = matcher.Match(features1, features2);
            matchingPoints = results[0].Count(); // similarity of image1 to image2
            ////matchingPoints = results[1].Count(); // similarity of image2 to image1

            Console.WriteLine("matched points: {0}", matchingPoints);

            sourcebox1.Image = bitmap1;
            sourcebox2.Image = bitmap2;
            var marker1 = new FeaturesMarker(features1, 30);
            var marker2 = new FeaturesMarker(features2, 30);



            double similPercent = 0;
            if (matchingPoints <= 0)
            {
                similPercent = 0.0f;
            }
            similPercent = (matchingPoints * 100d) / (double)modelPoints;

            Console.WriteLine("score: {0}", similPercent);

            simil1.Text = similPercent.ToString("##.##") + "%";
            simil2.Text = (score*100.00d).ToString("##.##") + "%";

            angle_text.Text = angle2.ToString("##.##") + "°";
            resultbox1.Image = marker1.Apply(grey1);
            resultbox2.Image = marker2.Apply(grey2);

            //resultbox.Image = resultdif;

            //CorrelationMatching cormatch = new CorrelationMatching(3, baboon, result);
            //Console.WriteLine("max distance: {0}", cormatch.GetHashCode());
        }


        private void process2()
        {

        }
    }
}
