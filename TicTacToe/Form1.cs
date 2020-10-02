using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public int player = 2;//even = X turn, odd = O turn;
        public int turns = 0;// counting turns
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
                if (CheckDraw() == true)
                {
                    MessageBox.Show("Tie Game!");
                    sd++;
                    NewGame();
                }
                if (CheckWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X Won!");
                        s1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("O Won!");
                        s2++;
                        NewGame();

                    }
                }
                

            }
        }

        private void NWGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        void NewGame()
        {
            player = 2;
            turns = 0;
            A1.Text = A2.Text = A3.Text = B1.Text = B2.Text = B3.Text = C1.Text = C2.Text = C3.Text = "";
            label1.Text = "X: " + s1;
            label2.Text = "O: " + s2;
            label3.Text = "Draws: " + sd;
        }
        bool CheckDraw()
        {
            if ((turns == 9) && CheckWinner() == false)
                return true;
            else
                return false;
        }
        bool CheckWinner()
        {
            // horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && A1.Text != "")
                return true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && B1.Text != "")
                return true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && C1.Text != "")
                return true;

            //vertical checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && A1.Text != "")
                return true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && A2.Text != "")
                return true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && A3.Text != "")
                return true;

            //diagonal checks
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && A3.Text != "")
                return true;
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && A1.Text != "")
                return true;
            else
                return false;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }
    }
}
