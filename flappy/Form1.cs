using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy
{
    public partial class Form1 : Form
    {

        int pipespeed = 1;
        int gravity = 12;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappy.Top += gravity;
            pipebottom.Left -= pipespeed;
            pipetop.Left -= pipespeed;
            scoretext.Text = "Score: " + score;

            if (pipebottom.Left < -50)
            {

                pipebottom.Left = 800;

                score++;

            }

            if (pipetop.Left < -80)
            {

                pipetop.Left = 600;
                score++;
            }

            if (flappy.Bounds.IntersectsWith(pipebottom.Bounds) || flappy.Bounds.IntersectsWith(pipetop.Bounds) || flappy.Bounds.IntersectsWith(ground.Bounds) || flappy.Top < -25)
            {

                endgame();

            }

            pipespeed = score + 1;

            if (pipespeed > 50) {
                pipespeed = 50;
            
            }

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)


        {


            if (e.KeyCode == Keys.Space)
            {

                gravity = -12;

            }

        }



        private void gamekeeyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {

                gravity = 10;

            }

        }

        private void endgame()
        {

            timer1.Stop();
            scoretext.Text += "Game is over !!!";


        }




    }
}
