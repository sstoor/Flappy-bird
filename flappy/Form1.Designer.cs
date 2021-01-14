namespace flappy
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
            this.components = new System.ComponentModel.Container();
            this.scoretext = new System.Windows.Forms.Label();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.flappy = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).BeginInit();
            this.SuspendLayout();
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(12, 9);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(56, 38);
            this.scoretext.TabIndex = 4;
            this.scoretext.Text = " 0";
            this.scoretext.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pipebottom
            // 
            this.pipebottom.Image = global::flappy.Properties.Resources.pipe_180___Copy1;
            this.pipebottom.Location = new System.Drawing.Point(385, 349);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(98, 251);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 5;
            this.pipebottom.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.Image = global::flappy.Properties.Resources.pipe_180;
            this.pipetop.Location = new System.Drawing.Point(620, 9);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(100, 248);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 3;
            this.pipetop.TabStop = false;
            // 
            // ground
            // 
            this.ground.AccessibleName = "bottom";
            this.ground.Image = global::flappy.Properties.Resources.floor_sprite;
            this.ground.Location = new System.Drawing.Point(-6, 595);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(810, 270);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // flappy
            // 
            this.flappy.Image = global::flappy.Properties.Resources.flappy;
            this.flappy.Location = new System.Drawing.Point(172, 88);
            this.flappy.Name = "flappy";
            this.flappy.Size = new System.Drawing.Size(33, 39);
            this.flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappy.TabIndex = 0;
            this.flappy.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(798, 664);
            this.Controls.Add(this.flappy);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappy;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.Timer timer1;
    }
}

