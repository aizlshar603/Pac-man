///pac man
///by Aizlea
///Feb. 2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Pac_Man
{
    public partial class PacMan : Form
    {
        public PacMan()
        {
            InitializeComponent();
        }

        private void PlayGame_Click(object sender, EventArgs e)
        {
            //clear button
            Graphics g = this.CreateGraphics();
            PlayGame.Visible = false;
            g.Clear(Color.Black);
              
            //draw lines 
            Pen drawPen = new Pen(Color.Blue, 10);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            
            //draw pac man 
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            g.FillPie(drawBrush, 20, 20, 50, 50, 30, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            
            //moving pacman to the right
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 20, 20, 50, 50, 30, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 40, 20, 50, 50, 30, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 60, 20, 50, 50, 30, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 80, 20, 50, 50, 30, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 100, 20, 50, 50, 30, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 120, 20, 50, 50, 30, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 140, 20, 50, 50, 30, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 160, 20, 50, 50, 30, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 180, 20, 50, 50, 30, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 200, 20, 50, 50, 30, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            //moving down
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 200, 20, 50, 50, 80, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 200, 20, 50, 50, 100, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 200, 40, 50, 50, 100, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 200, 60, 50, 50, 100, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 200, 80, 50, 50, 100, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 0, 10, 275, 10);
            g.DrawLine(drawPen, 0, 80, 175, 80);
            g.DrawLine(drawPen, 275, 10, 275, 150);
            g.DrawLine(drawPen, 175, 80, 175, 150);
            g.FillPie(drawBrush, 200, 100, 50, 50, 100, 360);
            
            //End of game
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            drawBrush.Color = Color.Red;
            g.DrawString ("Game Over", drawFont, drawBrush ,50, 180);
            Thread.Sleep(1000);
            g.Clear(Color.Black);


        }
    }
}
