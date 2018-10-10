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
            this.sourcebox_btn = new System.Windows.Forms.Button();
            this.source2box_btn = new System.Windows.Forms.Button();
            this.process_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.simil = new System.Windows.Forms.Label();
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
            // sourcebox_btn
            // 
            this.sourcebox_btn.Location = new System.Drawing.Point(127, 384);
            this.sourcebox_btn.Name = "sourcebox_btn";
            this.sourcebox_btn.Size = new System.Drawing.Size(59, 28);
            this.sourcebox_btn.TabIndex = 4;
            this.sourcebox_btn.Text = "...";
            this.sourcebox_btn.UseVisualStyleBackColor = true;
            this.sourcebox_btn.Click += new System.EventHandler(this.sourcebox_btn_Click);
            // 
            // source2box_btn
            // 
            this.source2box_btn.Location = new System.Drawing.Point(433, 384);
            this.source2box_btn.Name = "source2box_btn";
            this.source2box_btn.Size = new System.Drawing.Size(59, 28);
            this.source2box_btn.TabIndex = 5;
            this.source2box_btn.Text = "...";
            this.source2box_btn.UseVisualStyleBackColor = true;
            this.source2box_btn.Click += new System.EventHandler(this.source2box_btn_Click);
            // 
            // process_btn
            // 
            this.process_btn.Location = new System.Drawing.Point(764, 384);
            this.process_btn.Name = "process_btn";
            this.process_btn.Size = new System.Drawing.Size(59, 28);
            this.process_btn.TabIndex = 6;
            this.process_btn.Text = "process";
            this.process_btn.UseVisualStyleBackColor = true;
            this.process_btn.Click += new System.EventHandler(this.process_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1000, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Similarity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1091, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // simil
            // 
            this.simil.AutoSize = true;
            this.simil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simil.Location = new System.Drawing.Point(1077, 32);
            this.simil.Name = "simil";
            this.simil.Size = new System.Drawing.Size(21, 18);
            this.simil.TabIndex = 9;
            this.simil.Text = "%";
            // 
            // SpecialTopicsFinals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 681);
            this.Controls.Add(this.simil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.process_btn);
            this.Controls.Add(this.source2box_btn);
            this.Controls.Add(this.sourcebox_btn);
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
            this.PerformLayout();

        }

        #endregion

        private Accord.Controls.PictureBox sourcebox;
        private Accord.Controls.PictureBox pictureBox1;
        private Accord.Controls.PictureBox source2box;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Accord.Controls.PictureBox resultbox;
        private System.Windows.Forms.Button sourcebox_btn;
        private System.Windows.Forms.Button source2box_btn;
        private System.Windows.Forms.Button process_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label simil;
    }
}

