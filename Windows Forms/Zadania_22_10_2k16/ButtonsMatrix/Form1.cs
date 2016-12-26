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

namespace ButtonsMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int i, j, k;

            k = 1;

            for (i = 1; i < 5; i++)
            {
                for (j = 1; j < 5; j++)
                {
                    Button button = new Button();
                    button.Left = (j * 100) - 100;
                    button.Top = (i * 100) - 100;
                    button.Width = 100;
                    button.Height = 100;
                    button.Text = k.ToString();
                    button.Parent = this;

                    if ((i+j)%2 == 0)
                    {
                        button.BackColor = Color.Black;
                        button.ForeColor = Color.White;
                    }

                    button.MouseHover += Button_MouseHover;
                    button.MouseLeave += Button_MouseLeave;
                    k++;
                }  
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.FontFamily, 8);
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font.FontFamily, 14);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
