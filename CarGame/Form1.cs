using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameend();
            coins(gamespeed);
            collectedCoin();
        }

        void moveline(int speed)
        {
            if(stripe1.Top>=500)
                stripe1.Top = 0;
            else
                stripe1.Top += speed;

            if (stripe2.Top >= 500)
                stripe2.Top = 0;
            else
                stripe2.Top += speed;

            if (stripe3.Top >= 500)
                stripe3.Top = 0;
            else
                stripe3.Top += speed;

            if (stripe4.Top >= 500)
                stripe4.Top = 0;
            else
                stripe4.Top += speed;

        }

        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                if(car.Right< 330)
                    car.Left += 8;
            }
            if(e.KeyCode== Keys.A)
            {
                if(car.Left>10)
                    car.Left += -8;
            }
            if(e.KeyCode == Keys.W)
            {
                if(gamespeed < 21) { gamespeed++; }
            }
            if(e.KeyCode == Keys.S)
            {
                if (gamespeed > 0) { gamespeed--; }
            }
        }

        Random random = new Random();
        int x, y;
        void enemy(int speed)
        {
            if(enemy1.Top >=500)
            { x = random.Next(10, 135);
                enemy1.Location = new Point(x, 0);
            }
            else { enemy1.Top += speed; }

            if (enemy2.Top >= 500)
            {
                x = random.Next(10, 300);
                enemy2.Location = new Point(x, 0);
            }
            else { enemy2.Top += speed; }

            if (enemy3.Top >= 500)
            {
                x = random.Next(250, 300);
                enemy3.Location = new Point(x, 0);
            }
            else { enemy3.Top += speed; }
        }

        int collectedcoins = 0;

        void collectedCoin()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            { collectedcoins++; Coinlbl.Text = "Coins:" + collectedcoins.ToString();
                x = random.Next(10, 110);
                coin1.Location = new Point(x, 0);
            }
            if(car.Bounds.IntersectsWith(coin2.Bounds))
            { collectedcoins++; Coinlbl.Text = "Coins:" + collectedcoins.ToString();
                x = random.Next(110, 235);
                coin2.Location = new Point(x, 0);
            }
            if(car.Bounds.IntersectsWith(coin3.Bounds))
            { collectedcoins++; Coinlbl.Text = "Coins:" + collectedcoins.ToString();
                x = random.Next(10, 300);
                coin3.Location = new Point(x, 0);
            }
            if(car.Bounds.IntersectsWith(coin4.Bounds))
            { collectedcoins++; Coinlbl.Text = "Coins:" + collectedcoins.ToString();
                x = random.Next(235, 300);
                coin4.Location = new Point(x, 0);
            }
        }
        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = random.Next(10, 110);
                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if(coin2.Top >= 500)
            {
                x = random.Next(110, 235);
                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }

            if(coin3.Top >= 500)
            {
                x = random.Next(10, 300);
                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }

            if(coin4.Top >= 500)
            {
                x = random.Next(235, 300);
                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }


        }

        void gameend()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds)) { timer1.Enabled = false; over.Visible = true; }
            if (car.Bounds.IntersectsWith(enemy2.Bounds)) { timer1.Enabled = false; over.Visible = true; }
            if (car.Bounds.IntersectsWith(enemy3.Bounds)) { timer1.Enabled = false; over.Visible = true; }
        }
    }
}
