﻿using System;
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
            sourcebox.SizeMode = PictureBoxSizeMode.Zoom;
            source2box.SizeMode = PictureBoxSizeMode.Zoom;
            resultbox.SizeMode = PictureBoxSizeMode.Zoom;


            TestImages t = new TestImages();

            string path_earl = System.IO.Path.GetFullPath(@"../../janre1.png");
            string path_janre1 = System.IO.Path.GetFullPath(@"../../earl.png");

            var bitmap = (Bitmap)Accord.Imaging.Image.FromFile(path_earl);
            var bitmap1 = new Bitmap(path_earl);
            var bitmap2 = new Bitmap(path_janre1);
            var hash1 = ImagePhash.ComputeDigest(bitmap1.ToLuminanceImage());
            var hash2 = ImagePhash.ComputeDigest(bitmap2.ToLuminanceImage());
            var score = ImagePhash.GetCrossCorrelation(hash1, hash2);

            Console.WriteLine("score: {0}", score);

            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            // apply the filter to the model
            Bitmap grey1 = filter.Apply(bitmap1);
            // Apply the filter to the observed image
            Bitmap grey2 = filter.Apply(bitmap2);
            int modelPoints = 0, matchingPoints = 0;


            //CorrelationMatching matcher = new CorrelationMatching(5, grey1, grey2);
            //var results = matcher.GetHashCode();
            var detector = new FastCornersDetector(15);
            var freak = new FastRetinaKeypointDetector(detector);
            List<FastRetinaKeypoint> features1 = (List<FastRetinaKeypoint>)freak.Transform(grey1);
            modelPoints = features1.Count();

            Console.WriteLine("count: {0}", modelPoints);


            List<FastRetinaKeypoint> features2 = (List<FastRetinaKeypoint>)freak.Transform(grey2);

            Console.WriteLine("count: {0}", features2.Count());

            KNearestNeighborMatching matcher = new KNearestNeighborMatching(5);
            var results = matcher.Match(features1, features2);
            matchingPoints = results.Count();
            Console.WriteLine("matched points: {0}", matchingPoints);

            sourcebox.Image = grey1;
            source2box.Image = grey2;
            var marker = new FeaturesMarker(features1, 20);
            resultbox.Image = marker.Apply(grey1);

            float similPercent = 0;
            if (matchingPoints <= 0)
            {
                similPercent = 0.0f;
            }
            similPercent = (matchingPoints * 100) / modelPoints;

            Console.WriteLine("score: {0}", similPercent);

            //resultbox.Image = resultdif;

            //CorrelationMatching cormatch = new CorrelationMatching(3, baboon, result);
            //Console.WriteLine("max distance: {0}", cormatch.GetHashCode());
        }
    }
}
