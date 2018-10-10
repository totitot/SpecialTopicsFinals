namespace SpecialTopicsFinals
{
    partial class SpecialTopicsFinals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourcebox = new Accord.Controls.PictureBox();
            this.pictureBox1 = new Accord.Controls.PictureBox();
            this.source2box = new Accord.Controls.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.resultbox = new Accord.Controls.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sourcebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.source2box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultbox)).BeginInit();
            this.SuspendLayout();
            // 
            // sourcebox
            // 
            this.sourcebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourcebox.Image = null;
            this.sourcebox.Location = new System.Drawing.Point(34, 22);
            this.sourcebox.Name = "sourcebox";
            this.sourcebox.Size = new System.Drawing.Size(260, 344);
            this.sourcebox.TabIndex = 0;
            this.sourcebox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // source2box
            // 
            this.source2box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.source2box.Image = null;
            this.source2box.Location = new System.Drawing.Point(340, 22);
            this.source2box.Name = "source2box";
            this.source2box.Size = new System.Drawing.Size(260, 344);
            this.source2box.TabIndex = 2;
            this.source2box.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // resultbox
            // 
            this.resultbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultbox.Image = null;
            this.resultbox.Location = new System.Drawing.Point(642, 22);
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(294, 344);
            this.resultbox.TabIndex = 3;
            this.resultbox.TabStop = false;
            // 
            // SpecialTopicsFinals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 681);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.source2box);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sourcebox);
            this.Name = "SpecialTopicsFinals";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourcebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.source2box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Accord.Controls.PictureBox sourcebox;
        private Accord.Controls.PictureBox pictureBox1;
        private Accord.Controls.PictureBox source2box;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Accord.Controls.PictureBox resultbox;
    }
}

