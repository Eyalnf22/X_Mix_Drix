using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormX
{
    public partial class Form1 : Form
    {
        int row = 3;
        int size = 60;
        int space = 100;
        bool turn = true;
        Button[,] btns;
        //if turn is true therfore X is palying, false means O plays.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateBoard();
        }

        //sets the buttons on the board
        private void CreateBoard()
        {
            btns = new Button[row, row];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Button b = new Button();
                    b.Size = new Size(size, size);
                    b.Location = new Point(i * space, j * space);
                    b.Click += choose;
                    b.Font = new Font("Arial", 24, FontStyle.Bold);
                    btns[i, j] = b;

                    pnl.Controls.Add(b);
                }
            }
        }

        //mark the player's chosie and switch turns.
        private void choose(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.Text == "")
            {
                if (turn)
                {
                    myTurn.Text = "Turn: O";
                    b.Text = "X";
                }
                else
                {
                    myTurn.Text = "Turn: X";
                    b.Text = "O";
                }

                if (checkWin())
                {
                    string txt = "";
                    if (turn)
                        txt = "X Wins!";
                    else
                        txt = "O Wins!";
                    title.Text = txt;

                    DisableGame();
                }
                turn = !turn;

            }
        }

        //disable the buttons.
        private void DisableGame()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    btns[i, j].Enabled = false;
                }
            }
            afterPnl.Visible = true;
        }

        //cheks for a winner for a row, colom or slope.
        private bool checkWin()
        {
            for (int i = 0; i < row; i++)
            {
                if (btns[i, 0].Text == btns[i, 1].Text && btns[i, 2].Text == btns[i, 1].Text && btns[i, 1].Text != "")
                    return true;
                if (btns[0, i].Text == btns[1, i].Text && btns[2, i].Text == btns[1, i].Text && btns[1, i].Text != "")
                    return true;
            }
            if (btns[0, 2].Text == btns[1, 1].Text && btns[1, 1].Text == btns[2, 0].Text && btns[2, 0].Text != "")
                return true;
            else if (btns[0, 0].Text == btns[1, 1].Text && btns[1, 1].Text == btns[2, 2].Text && btns[1, 1].Text != "")
                return true;

            return false;
        }

        //restart the game
        private void newGame_Click(object sender, EventArgs e)
        {
            turn = true;
           
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    btns[i, j].Enabled = true;
                    btns[i, j].Text = "";
                }
            }
            afterPnl.Visible = false;
            myTurn.Text = "Turn: X";


        }
    }
}

