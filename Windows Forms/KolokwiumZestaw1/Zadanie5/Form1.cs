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

            int x = 50;
            int y = 50;

            Brush b1 = Brushes.Blue;
            Brush b2 = Brushes.Yellow;
            Brush b3 = Brushes.White;

            g.FillEllipse(b1, x, y, 120, 120);
            g.FillEllipse(b2, x + 40, y + 40, 40, 40);
            g.FillEllipse(b3, x + 40, y + 100, 40, 40);
            g.FillEllipse(b1, x + 50, y + 110, 20, 20);
        }
    }
}
