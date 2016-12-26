using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konkursLogoUMK
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

            g.FillEllipse(Brushes.Blue, x, y, 120, 120);
            g.FillEllipse(Brushes.Yellow, x + 40, y + 40, 40, 40);
            g.FillEllipse(Brushes.White, x + 40, y + 100, 40, 40);
            g.FillEllipse(Brushes.Blue, x + 50, y + 110, 20, 20);
        }
    }
}
