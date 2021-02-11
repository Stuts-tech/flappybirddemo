using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappybirddemo
{
    public partial class Form1 : Form

    {
        int pipespeed = 8;
        int gravity = 5;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gametimerevent(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            pipebottom.Left -= pipespeed;
            pipetop.Left -= pipespeed;
            scoretext.Text = "score: " + score;
            if (pipebottom.Left < -50)
            {
                pipebottom.Left = 850;
                score++;
            }
            if (pipetop.Left < -80)
            {
                pipetop.Left = 950;
                score++;
            }
            if(flappybird.Bounds.IntersectsWith(pipebottom.Bounds)|| flappybird.Bounds.IntersectsWith(pipetop.Bounds)|| flappybird.Bounds.IntersectsWith(ground.Bounds)|| flappybird.Top < -25)
            {
                endgame();
            }

            if (score > 5)
            {
                pipespeed = 15;
            }

            

        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }

        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }

        }

        private void endgame()
        {
            gametimer.Stop();
            scoretext.Text += "  game over";

        }
    }
}
