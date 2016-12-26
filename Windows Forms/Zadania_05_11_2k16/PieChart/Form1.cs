using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PieChart
{
    public partial class Form1 : Form
    {
        int[] number;
        float[] p;
        float pS = 0;
        Brush[] b;
        int sum = 0;
        Random rng = new Random();
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            numberInitialize();
            brushInitialize();
            labelInitialize();
        }

        private void numberInitialize()
        {
            number = new int[19];
            for (int i = 0; i < 19; i++)
            {
                number[i] = rng.Next(20);
                if (number[i] == 0) i--;
                else
                sum += number[i];
            }

            p = new float[19];
            for (int i = 0; i < 19; i++)
            {
                p[i] = sum / number[i];
            }

            pS = 0;
            sum = 0;
        }
        private void brushInitialize()
        {
            b = new Brush[19];
            b[0] = new SolidBrush(Color.AliceBlue);
            b[1] = new SolidBrush(Color.SeaGreen);
            b[2] = new SolidBrush(Color.Tomato);
            b[3] = new SolidBrush(Color.PaleVioletRed);
            b[4] = new SolidBrush(Color.OliveDrab);
            b[5] = new SolidBrush(Color.MediumTurquoise);
            b[6] = new SolidBrush(Color.LightSeaGreen);
            b[7] = new SolidBrush(Color.LemonChiffon);
            b[8] = new SolidBrush(Color.Ivory);
            b[9] = new SolidBrush(Color.Green);
            b[10] = new SolidBrush(Color.Gold);
            b[11] = new SolidBrush(Color.Gainsboro);
            b[12] = new SolidBrush(Color.Firebrick);
            b[13] = new SolidBrush(Color.DarkViolet);
            b[14] = new SolidBrush(Color.DarkOrchid);
            b[15] = new SolidBrush(Color.Crimson);
            b[16] = new SolidBrush(Color.Chocolate);
            b[17] = new SolidBrush(Color.Bisque);
            b[18] = new SolidBrush(Color.Aqua);
        }

        private void labelInitialize()
        {
            string tempLabel;
            label1.Text = "";
            for (int i = 0; i < 19; i++)
            {
                tempLabel = "(" + (i+1).ToString() + ") - [" + number[i].ToString() + "] - " + p[i].ToString() + "%";
                label1.Text += tempLabel + Environment.NewLine;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, 300, 200);

            g.FillPie(b[0], rect, 0, p[0]);
            pS = p[0];
            for (int i = 1; i < 19; i++)
            {
                g.FillPie(b[i], rect, pS, p[i]);
                pS += p[i - 1];
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberInitialize();
            labelInitialize();
            Invalidate();
        }
    }
}
