using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaClauseIsComingToTown
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipeSpeed = 6;
        int score = 0;
        int backroundSpeed = 3;
        public Form1()
        {
            InitializeComponent();

        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }



        private void gameOver()
        {
            timer1.Stop();
            scorelabel.Text = $"Game Over!";
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void Sleigh_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Sleigh.Top += gravity;
            SnowFlake.Left -= pipeSpeed;
            Tree.Left -= pipeSpeed;
            moon.Left -= backroundSpeed;
            house.Left -= backroundSpeed;
            scorelabel.Text = $"score: {score}";

            if (SnowFlake.Left < -600)
            {
                SnowFlake.Left = 650;
            }
            if (Tree.Left < -499)
            {
                Tree.Left = 699;
                score++;
            }
            if (moon.Left < -600)
            {
                moon.Left = 600;
            }
            if (house.Left < -500)
            {
                house.Left = 600;
            }
            if (Sleigh.Top < -500)
            {
                gameOver();
            }
            if (Sleigh.Bounds.IntersectsWith(SnowFlake.Bounds) || Sleigh.Bounds.IntersectsWith(Tree.Bounds) || Sleigh.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }

        }

      
    }
}
    

