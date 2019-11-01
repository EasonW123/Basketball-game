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
            this.outputLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.pictureRed = new System.Windows.Forms.PictureBox();
            this.pictureBlue = new System.Windows.Forms.PictureBox();
            this.pictureYellow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureYellow)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.outputLabel.Location = new System.Drawing.Point(390, 39);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(356, 79);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "What player do your want to be?";
            // 
            // redLabel
            // 
            this.redLabel.ForeColor = System.Drawing.Color.White;
            this.redLabel.Location = new System.Drawing.Point(468, 166);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(293, 58);
            this.redLabel.TabIndex = 1;
            this.redLabel.Text = "Lebron James";
            // 
            // blueLabel
            // 
            this.blueLabel.ForeColor = System.Drawing.Color.White;
            this.blueLabel.Location = new System.Drawing.Point(468, 237);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(225, 54);
            this.blueLabel.TabIndex = 2;
            this.blueLabel.Text = "Kyrie Ivring";
            // 
            // yellowLabel
            // 
            this.yellowLabel.ForeColor = System.Drawing.Color.White;
            this.yellowLabel.Location = new System.Drawing.Point(468, 311);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(189, 52);
            this.yellowLabel.TabIndex = 3;
            // 
            // pictureRed
            // 
            this.pictureRed.BackgroundImage = global::Basketball_game.Properties.Resources.red_50x50;
            this.pictureRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureRed.Location = new System.Drawing.Point(340, 166);
            this.pictureRed.Name = "pictureRed";
            this.pictureRed.Size = new System.Drawing.Size(100, 50);
            this.pictureRed.TabIndex = 4;
            this.pictureRed.TabStop = false;
            // 
            // pictureBlue
            // 
            this.pictureBlue.BackgroundImage = global::Basketball_game.Properties.Resources.blue_50x50;
            this.pictureBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBlue.Location = new System.Drawing.Point(340, 237);
            this.pictureBlue.Name = "pictureBlue";
            this.pictureBlue.Size = new System.Drawing.Size(100, 50);
            this.pictureBlue.TabIndex = 5;
            this.pictureBlue.TabStop = false;
            // 
            // pictureYellow
            // 
            this.pictureYellow.BackgroundImage = global::Basketball_game.Properties.Resources.yellow_50x50;
            this.pictureYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureYellow.Location = new System.Drawing.Point(340, 311);
            this.pictureYellow.Name = "pictureYellow";
            this.pictureYellow.Size = new System.Drawing.Size(100, 50);
            this.pictureYellow.TabIndex = 6;
            this.pictureYellow.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureYellow);
            this.Controls.Add(this.pictureBlue);
            this.Controls.Add(this.pictureRed);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureYellow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.PictureBox pictureRed;
        private System.Windows.Forms.PictureBox pictureBlue;
        private System.Windows.Forms.PictureBox pictureYellow;
    }
}

