using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_Wykres
{
    public partial class Form1 : Form
    {
        private CultureInfo polskaKultura = new CultureInfo("pl-PL");
        public double a, b, c, D;
        Pen blackPen = new Pen(Color.Black, 3);
        Point x1 = new Point(-50, 0);
        Point x2 = new Point(50, 0);
        Point W = new Point(0, -20);
        Point s = new Point(0, 0);
        Point k = new Point(0, 0);
 
        public Form1()
        {
            InitializeComponent();
        }

        private double Delta(double a, double b, double c)
        {
            return (b * b) - (4 * a * c);
        }
        private double[] squareRoot(double a, double b, double c, double delta)
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

        public void button1_Click(object sender, EventArgs e)
        {
            

            a = double.Parse(textBox1.Text, polskaKultura);
            b = double.Parse(textBox2.Text, polskaKultura);
            c = double.Parse(textBox3.Text, polskaKultura);

            D = Delta(a, b, c);

            x1 = new Point((int)squareRoot(a, b, c, D)[0], 0);
            x2 = new Point((int)squareRoot(a, b, c, D)[1], 0);
            s = new Point(0, (int)c);
            k = new Point(10, (int)(a*100+b*10+c));
            W = new Point((int)(-b/2*a), (int)(-D/4*a));
            Invalidate();
        }

        public Point[] createPoints(Point x1, Point x2, Point W)
        {
            Point[] wykres = {x1, W, x2};
            return wykres;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point osX1 = new Point(0, 200);
            Point osX2 = new Point(400, 200);
            Point osY1 = new Point(200, 0);
            Point osY2 = new Point(200, 400);

            g.DrawLine(blackPen, osX1, osX2);
            g.DrawLine(blackPen, osY1, osY2);
            g.DrawBeziers(blackPen, createPoints(x1, x2, W));

        }

    }
}
