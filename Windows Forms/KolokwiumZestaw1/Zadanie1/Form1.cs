using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1_ValueChanged(null, null);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value;
            label1.Text = trackBar1.Value.ToString();
        }
    }
}
