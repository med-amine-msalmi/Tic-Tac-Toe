using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            e.Graphics.DrawLine(pen, 320, 105, 320, 410);
            e.Graphics.DrawLine(pen,205,220,660,220);
            e.Graphics.DrawLine(pen, 425, 105, 425, 410);
            
            

            
          
        }

     
    }
}
