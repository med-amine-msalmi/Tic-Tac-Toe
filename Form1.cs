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
       

        private Turn playerTurn=Turn.Player1;
      
        private Turn[,] Board = new Turn[3, 3];
        public Form1()
        {
            InitializeComponent();
        }
        private bool changeTicTacToe(PictureBox box)
        {
         
            switch (playerTurn)
            {
                case Turn.Player1:
                    box.Image = Resources.X;
                   
                    return true;
                case Turn.Player2:
                    box.Image = Resources.O;
                 
                    return true;
                case Turn.Empty:
                    MessageBox.Show("Restart the game to play again", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                default:
                    return false;
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
            
            Board[x,y] = player;
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
            for(int row = 0; row < 3; row++)
            {
               
                    if (Board[row, 0] == playerTurn & Board[row, 1] == playerTurn & Board[row, 2] == playerTurn)
                    {

                    return true;
                    }
               

            }
            //check columns 
            for(int column = 0; column < 3; column++)
            {
                
                     if(Board[0,column]==playerTurn & Board[1,column]==playerTurn & Board[2, column] == playerTurn)
                     {
                         return true;
                     }

                 
            }
            //checks diagnols
            if(Board[0,0]==playerTurn & Board[1,1]==playerTurn & Board[2,2]==playerTurn)
                { return true ; }
            if (Board[0,2]==playerTurn & Board[1,1]==playerTurn & Board[2, 0] == playerTurn)
            {
                return true;
            }
            return false;
        }
        private bool checkDraw()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Board[i, j] == Turn.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void gameResult()
        {

            if (checkWinner())
            {

                lbWinner.Text=playerTurn.ToString();
                MessageBox.Show($"{playerTurn} wins the game", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playerTurn = Turn.Empty;
                return;
            }
            if (checkDraw())
            {

                  MessageBox.Show("Draw , Restart the game to play again", "Game Over ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  playerTurn = Turn.Empty;
                  return;
            }
               
            changePlayerTurn();
        }
        private void restartGame()
        {
            playerTurn = Turn.Player1;
            lbTurn.Text = playerTurn.ToString();
            lbWinner.Text="In Progress";
            Board = new Turn[3, 3];
            pictureBox1.Image = Resources.games;
            pictureBox2.Image = Resources.games;
            pictureBox3.Image = Resources.games;
            pictureBox4.Image = Resources.games;
            pictureBox5.Image = Resources.games;
            pictureBox6.Image = Resources.games;
            pictureBox7.Image = Resources.games;
            pictureBox8.Image = Resources.games;
            pictureBox9.Image = Resources.games;
        
        }
        
        //assign one event for the all the 9 pictureBoxes
        
        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox=(PictureBox)sender;
            if(changeTicTacToe(pictureBox))
            {

                short xCordiante = short.Parse(pictureBox.Tag.ToString().Split(',')[0]);
                short yCordiante = short.Parse(pictureBox.Tag.ToString().Split(',')[1]);
                setCordinateInBoard(xCordiante,yCordiante, playerTurn);
                gameResult();
            }
        }
       
        private void btRestart_Click(object sender, EventArgs e)
        {
            restartGame();
        }
    }
}
