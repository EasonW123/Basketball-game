namespace Basketball_game
{
    partial class Form1
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
            this.outLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.yellowImage = new System.Windows.Forms.PictureBox();
            this.sceneImage = new System.Windows.Forms.PictureBox();
            this.blueImage = new System.Windows.Forms.PictureBox();
            this.redImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yellowImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.BackColor = System.Drawing.Color.Black;
            this.outLabel.ForeColor = System.Drawing.Color.White;
            this.outLabel.Location = new System.Drawing.Point(93, 26);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(180, 20);
            this.outLabel.TabIndex = 9;
            this.outLabel.Text = "Who do you want to be?";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.BackColor = System.Drawing.Color.Black;
            this.rLabel.ForeColor = System.Drawing.Color.White;
            this.rLabel.Location = new System.Drawing.Point(296, 406);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(110, 20);
            this.rLabel.TabIndex = 10;
            this.rLabel.Text = "Lebron James";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.BackColor = System.Drawing.Color.Black;
            this.bLabel.ForeColor = System.Drawing.Color.White;
            this.bLabel.Location = new System.Drawing.Point(296, 464);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(85, 20);
            this.bLabel.TabIndex = 11;
            this.bLabel.Text = "Kyrie Ivring";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.BackColor = System.Drawing.Color.Black;
            this.yLabel.ForeColor = System.Drawing.Color.White;
            this.yLabel.Location = new System.Drawing.Point(296, 535);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(0, 20);
            this.yLabel.TabIndex = 12;
            // 
            // yellowImage
            // 
            this.yellowImage.BackgroundImage = global::Basketball_game.Properties.Resources.yellow_50x50;
            this.yellowImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yellowImage.Location = new System.Drawing.Point(182, 507);
            this.yellowImage.Name = "yellowImage";
            this.yellowImage.Size = new System.Drawing.Size(59, 50);
            this.yellowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowImage.TabIndex = 13;
            this.yellowImage.TabStop = false;
            // 
            // sceneImage
            // 
            this.sceneImage.BackgroundImage = global::Basketball_game.Properties.Resources.kyrie__lebron;
            this.sceneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sceneImage.Location = new System.Drawing.Point(182, 86);
            this.sceneImage.Name = "sceneImage";
            this.sceneImage.Size = new System.Drawing.Size(509, 243);
            this.sceneImage.TabIndex = 8;
            this.sceneImage.TabStop = false;
            // 
            // blueImage
            // 
            this.blueImage.BackgroundImage = global::Basketball_game.Properties.Resources.blue_50x50;
            this.blueImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.blueImage.Location = new System.Drawing.Point(182, 451);
            this.blueImage.Name = "blueImage";
            this.blueImage.Size = new System.Drawing.Size(59, 50);
            this.blueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueImage.TabIndex = 7;
            this.blueImage.TabStop = false;
            // 
            // redImage
            // 
            this.redImage.BackgroundImage = global::Basketball_game.Properties.Resources.red_50x50;
            this.redImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.redImage.Location = new System.Drawing.Point(182, 395);
            this.redImage.Name = "redImage";
            this.redImage.Size = new System.Drawing.Size(59, 50);
            this.redImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redImage.TabIndex = 6;
            this.redImage.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(872, 586);
            this.Controls.Add(this.yellowImage);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.rLabel);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.sceneImage);
            this.Controls.Add(this.blueImage);
            this.Controls.Add(this.redImage);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.yellowImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.PictureBox pictureRed;
        private System.Windows.Forms.PictureBox pictureBlue;
        private System.Windows.Forms.PictureBox pictureYellow;
        private System.Windows.Forms.PictureBox sceneImage;
        private System.Windows.Forms.PictureBox blueImage;
        private System.Windows.Forms.PictureBox redImage;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.PictureBox yellowImage;
    }
}

