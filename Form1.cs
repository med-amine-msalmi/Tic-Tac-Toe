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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox1);
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe( pictureBox2);

        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox3);
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox4);
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox6);
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox7);
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox5);
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox8);
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox9);
        }
    }
}
