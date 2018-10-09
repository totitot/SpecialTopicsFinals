using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.DataSets;
using Accord.Imaging.Filters;
using Accord.Imaging;

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

            string path_earl = System.IO.Path.GetFullPath(@"../../earl.png");
            string path_janre1 = System.IO.Path.GetFullPath(@"../../janre1.png");
            //Bitmap baboon = t["girl.png"];
            Bitmap baboon = new Bitmap(path_earl);
            GaussianBlur blur = new GaussianBlur();

            //Bitmap result = blur.Apply(baboon);
            Bitmap result = new Bitmap(path_janre1);



            //BlobCounter bc = new BlobCounter();
            //bc.FilterBlobs = true;
            //bc.MinHeight = 10;
            //bc.MinWidth = 10;
            //bc.ProcessImage(baboon);


            //Blob[] blobs = bc.GetObjectsInformation();

            //bc.ExtractBlobsImage(baboon, blobs[0], true);

            //Console.WriteLine("number of blobs {0}", blobs.Length);

            //sourcebox.Image = baboon;
            //resultbox.Image = blobs[0].Image.ToManagedImage();

            Difference dif = new Difference(result);
            Bitmap resultdif = dif.Apply(baboon);

            sourcebox.Image = baboon;
            source2box.Image = result;
            resultbox.Image = resultdif;

            //CorrelationMatching cormatch = new CorrelationMatching(3, baboon, result);
            //Console.WriteLine("max distance: {0}", cormatch.GetHashCode());
        }
    }
}
