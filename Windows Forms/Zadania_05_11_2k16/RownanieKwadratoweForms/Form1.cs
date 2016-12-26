using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RownanieKwadratoweForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);

            label4.Text = result(square1(a, b, c, checkDelta(a, b, c)));
        }

        private int checkDelta(int a, int b, int c)
        {
            return (b * b) - (4 * a * c);
        }

        private double[] square1(int a, int b, int c, int delta)
        {
            double[] x = new double[2];
            if (delta > 0)
            {
                x[0] = (-b - Math.Sqrt(delta)) / (2 * a);
                x[1] = (-b + Math.Sqrt(delta)) / (2 * a);
            }
            else if (delta == 0)
            {
                x[0] = -b / (2 * a);
                x[1] = -b / (2 * a);
            }
            else return null;

            return x;
        }

        private string result(double[] x)
        {
            try
            {
                string _result = "x1 =" + x[0].ToString() + ", x2 = " + x[1].ToString();
                return _result;
            }
            catch
            {
                return "brak pierwiastków";
            }
            
        }
    }
}
