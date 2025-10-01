using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tic_tac_toe_game.Properties;

namespace tic_tac_toe_game
{
    public partial class Form1 : Form
    {
        enum Turn { Empty,Player1, Player2};
        enum Result { Player1, Player2,Draw };

        private Turn playerTurn=Turn.Player1;
        private Result result;
        private Turn[,] Board = new Turn[3, 3];
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
                    
                   
                    break;
                case Turn.Player2:
                    box.Image = Resources.O;
                   
                  
                    break;
                 
                default:
                    MessageBox.Show("Game Over", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        private void changePlayerTurn()
        {
            switch (playerTurn) { 
                case Turn.Player1:
                    playerTurn=Turn.Player2;
                    break;
                case Turn.Player2:
                    playerTurn=Turn.Player1;
                    break;
            }
            lbTurn.Text = playerTurn.ToString();
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

        private Turn checkWinner()
        {   
            //check rowz
            for(int row = 0; row < 2; row++)
            {
               
                    if (Board[row, 0] == playerTurn & Board[row, 1] == playerTurn & Board[row, 2] == playerTurn)
                    {
                        
                        return playerTurn;
                    }
               

            }
            //check columns 
            for(int column = 0; column < 2; column++)
            {
                
                     if(Board[0,column]==playerTurn & Board[1,column]==playerTurn & Board[2, column] == playerTurn)
                     {
                         return playerTurn;
                     }

                 
            }
            //checks diagnols
            if(Board[0,0]==playerTurn & Board[1,1]==playerTurn & Board[2,2]==playerTurn)
                { return playerTurn; }
            if (Board[0,2]==playerTurn & Board[1,1]==playerTurn & Board[2, 0] == playerTurn)
            {
                return playerTurn;
            }
            return Turn.Empty;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox1);
            setCordinateInBoard(0, 0, playerTurn);
            Turn Winner = checkWinner();
            if (Winner != Turn.Empty)
            {

                MessageBox.Show($"{Winner} wins the game", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            changePlayerTurn();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe( pictureBox2);
            setCordinateInBoard(0, 1, playerTurn);
            Turn Winner = checkWinner();
            if (Winner != Turn.Empty)
            {

                MessageBox.Show($"{Winner} wins the game", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            changePlayerTurn();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox3);
            setCordinateInBoard(0, 2, playerTurn);
            Turn Winner = checkWinner();
            if (Winner != Turn.Empty)
            {

                MessageBox.Show($"{Winner} wins the game", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            changePlayerTurn();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox4);

            Turn Winner = checkWinner();
            if (Winner != Turn.Empty)
            {

                MessageBox.Show($"{Winner} wins the game", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            changePlayerTurn() ;

        }
        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox5);
            setCordinateInBoard(1, 1, playerTurn);
            Turn Winner = checkWinner();
            if (Winner != Turn.Empty)
            {

                MessageBox.Show($"{Winner} wins the game", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox6);
            setCordinateInBoard(1,2,playerTurn);
            Turn Winner = checkWinner();
            if (Winner != Turn.Empty)
            {

                MessageBox.Show($"{Winner} wins the game", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            changePlayerTurn();


        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox7);
            setCordinateInBoard(2,0,playerTurn);
            Turn Winner = checkWinner();
            if (Winner != Turn.Empty)
            {

                MessageBox.Show($"{Winner} wins the game", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            changePlayerTurn();
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox8);
            setCordinateInBoard(2,1,playerTurn);
            Turn Winner=checkWinner();
            if (Winner!= Turn.Empty)
            {

                MessageBox.Show($"{Winner} wins the game", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            changePlayerTurn();
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            changeTicTacToe(pictureBox9);
            setCordinateInBoard(2,2,playerTurn);
            Turn Winner = checkWinner();
            if (Winner != Turn.Empty)
            {

                MessageBox.Show($"{Winner} wins the game", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            changePlayerTurn();
        }
    }
}
