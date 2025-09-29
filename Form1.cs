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
            Color Blue = Color.Blue; 
            Pen pen=new Pen(Blue);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
            pen.Width = 4;
            
            Point start = new Point(100, 100);
            Point end=new Point(100, 400);
            e.Graphics.DrawEllipse(pen, 10, 100,100,100);
            e.Graphics.DrawLine(pen, 119, 80, 119, 200);
            e.Graphics.DrawRectangle(pen, 200, 10, 300, 40);
        }
    }
}
