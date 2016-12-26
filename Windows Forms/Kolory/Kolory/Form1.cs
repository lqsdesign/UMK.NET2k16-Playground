using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = Properties.Settings.Default.R;
            trackBar2.Value = Properties.Settings.Default.G;
            trackBar3.Value = Properties.Settings.Default.B;
            Left = Properties.Settings.Default.L;
            Top = Properties.Settings.Default.T;
            Width = Properties.Settings.Default.W;
            Height = Properties.Settings.Default.H;
            trackBar1_Scroll(null, null);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(
                trackBar1.Value,
                trackBar2.Value,
                trackBar3.Value);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.R = (byte)trackBar1.Value;
            Properties.Settings.Default.G = (byte)trackBar2.Value;
            Properties.Settings.Default.B = (byte)trackBar3.Value;
            Properties.Settings.Default.L = Left;
            Properties.Settings.Default.T = Top;
            Properties.Settings.Default.W = Width;
            Properties.Settings.Default.H = Height;
            Properties.Settings.Default.Save();
        }
    }
}
