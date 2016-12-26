using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Płótno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.DobleBuffer, true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Random r = new Random();

            g.DrawRectangle(Pens.BlueViolet, 100, 100, 200, 50);
            g.FillEllipse(Brushes.Yellow, trackBar1.Value, 100, 100, 100);

            for (int y = 0; y < ClientSize.Height; ++y)
            {
                for (int x = 0; x < ClientSize.Width -1; ++x)
                {
                    //int _r = x * 255 / ClientSize.Width - 1;
                    //int _g = y * 255 / ClientSize.Height;

                    //int _r = r.Next(255);
                    //int _g = r.Next(255);
                    //int _b = r.Next(255);
                    int _r = (int)(127*(Math.Cos(0.1*(x + y)) + 1));
                    int _g = (int)(127*(Math.Sin(0.2*(y - x)) + 1));
                    int _b = 255;
                    Pen p = new Pen(Color.FromArgb(_r, _g, _b));
                    g.DrawLine(p, x, y, x + 1, y);
                }
            }
           
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
