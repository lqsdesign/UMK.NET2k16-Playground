using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Top = Properties.Settings.Default.T;
            Left = Properties.Settings.Default.L;
            Height = Properties.Settings.Default.H;
            Width = Properties.Settings.Default.W;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.T = Top;
            Properties.Settings.Default.L = Left;
            Properties.Settings.Default.H = Height;
            Properties.Settings.Default.W = Width;
            Properties.Settings.Default.Save();
        }
    }
}
