using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tic_tac_toe_game.Properties;

namespace tic_tac_toe_game
{
    public partial class Form1 : Form
    {
         enum Turn { Player1,Player2 };
         enum Result { Player1, Player2,Draw };

        private Turn playerTurn=Turn.Player1;
        private Result result;
        private Turn[,] Board = { { Turn.Player1, Turn.Player2,Turn.Player2 }, { Turn.Player1, Turn.Player2 ,Turn.Player1}, { Turn.Player1, Turn.Player2,Turn.Player1 } };
        public Form1()
        {
            InitializeComponent();
        }

        private void changeTicTacToe(PictureBox box)
        {
         
            switch (playerTurn)
            {
                case Turn.Player1:
                    box.Image = Resources.X;
                    playerTurn = Turn.Player2;
                    lbTurn.Text=playerTurn.ToString();
                    break;
                case Turn.Player2:
                    box.Image = Resources.O;
                    playerTurn = Turn.Player1;
                    lbTurn.Text = playerTurn.ToString();
                    break;
                default:
                    MessageBox.Show("Game Over", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        private void setCordinateInBoard(short x, short y,Turn player)
        {
            
            Board[x, y] = player;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen pen = new Pen(White);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
            pen.Width = 5;
            

            //painting X

            e.Graphics.DrawLine(pen, 20,30, 70, 80);
            e.Graphics.DrawLine(pen, 70, 30, 20, 80);

            // painting O
            e.Graphics.DrawEllipse(pen,720, 30, 56, 56);

            //
            //draw the table of tic tac toe 
            e.Graphics.DrawLine(pen, 320, 105, 320, 450);
            e.Graphics.DrawLine(pen,205,220,550,220);
            e.Graphics.DrawLine(pen, 425, 105, 425, 450);
            e.Graphics.DrawLine(pen, 205, 335, 550, 335); 
        }

        private bool checkWinner()
        {   
            //check rowz
            for(int row = 0; row < 2; row++)
            {
                if (Board[row,0]==playerTurn & Board[row,1]==playerTurn & Board[row, 2] == playerTurn)
                {
                    return true;
                }

            }
            //check columns 
            for(int column = 0; column < 2; column++)
            {
                if(Board[0,column]==playerTurn & Board[1,column]==playerTurn & Board[2, column] == playerTurn)
                {
                    return true;
                }
            }
            //checks diagnols
            if(Board[0,0]==playerTurn & Board[1,1]==playerTurn & Board[2,2]==playerTurn)
                { return true; }
            if (Board[0,2]==playerTurn & Board[1,1]==playerTurn & Board[2, 0] == playerTurn)
            {
                return true;
            }
            return false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            changeTicTacToe(pictureBox1);
            setCordinateInBoard(0, 0, playerTurn);
            
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe( pictureBox2);
            setCordinateInBoard(0, 1, playerTurn);
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox3);
            setCordinateInBoard(0, 2, playerTurn);
            if (checkWinner())
            {
                MessageBox.Show($"{playerTurn} wins the game");
            }
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox4);
            setCordinateInBoard(1,0,playerTurn);
            if (checkWinner())
            {
                MessageBox.Show($"{playerTurn} wins the game"," ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox5);
            setCordinateInBoard(1, 1, playerTurn);
            if (checkWinner())
            {
                MessageBox.Show($"{playerTurn} wins the game", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox6);
            setCordinateInBoard(1,2,playerTurn);
            if (checkWinner())
            {
                MessageBox.Show($"{playerTurn} wins the game", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox7);
            setCordinateInBoard(2,0,playerTurn);
            if (checkWinner())
            {
                MessageBox.Show($"{playerTurn} wins the game", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox8);
            setCordinateInBoard(2,1,playerTurn);
            if (checkWinner())
            {
                MessageBox.Show($"{playerTurn} wins the game", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox9);
            setCordinateInBoard(2,2,playerTurn);
            if (checkWinner())
            {
                MessageBox.Show($"{playerTurn} wins the game", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
