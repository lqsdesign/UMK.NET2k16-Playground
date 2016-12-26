using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int x = 100;
            int y = 100;
            Pen p1 = new Pen(Color.Blue, 5);
            Pen p2 = new Pen(Color.Black, 5);
            Pen p3 = new Pen(Color.Red, 5);
            Pen p4 = new Pen(Color.Yellow, 5);
            Pen p5 = new Pen(Color.Green, 5);

            g.DrawEllipse(p1, x, y, 50, 50);
            g.DrawEllipse(p4, x + 30, y + 30, 50, 50);

            g.DrawEllipse(p2, x + 60, y, 50, 50);
            g.DrawEllipse(p5, x + 90, y + 30, 50, 50);
            g.DrawEllipse(p3, x + 120, y, 50, 50);

            
            
        }
    }
}
