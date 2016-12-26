using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balwan
{
    public partial class Form1 : Form
    {
        Graphics g;
        int sniegFront = 500;
        int sniegBack = 400;

        int znikanieSzansa = 5;
        static Random rng = new Random();

        int[] sniegFrontX, sniegFrontY, sniegBackX, sniegBackY, transparencyF, transparencyB;
        public Form1()
        {
            InitializeComponent();
            InitializeSnow();
            //ustawienia pozwalające uniknąć mrugania obszarów
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void drawBackground(int h, PaintEventArgs e)
        {
            
            //sky
            SolidBrush sky = new SolidBrush(Color.DarkSlateBlue);
            g.FillRectangle(sky, 0, 0, ClientSize.Width, ClientSize.Height);

            //moon
            g.FillEllipse(Brushes.LightGoldenrodYellow, ClientSize.Width - 150, ClientSize.Height - h - 180, 120, 100);
            g.FillEllipse(sky, ClientSize.Width - 180, ClientSize.Height - h - 165, 120, 100);
            
            //ground
            g.FillRectangle(Brushes.Silver, 0, ClientSize.Height - h, ClientSize.Width, ClientSize.Height);
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            
            drawBackground(100, e);
            drawSniegBack(e);

            drawTree(100, 250, e);
            drawTree(140, 280, e);

            drawBalwan(300, 280, e);

            drawSniegFront(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < sniegFront; i++)
            {
                sniegFrontX[i] += 2;
                if (sniegFrontX[i] > ClientSize.Width)
                {
                    sniegFrontX[i] = 0;
                    sniegFrontY[i] = rng.Next(ClientSize.Height);
                    transparencyF[i] = 100;
                }

                sniegFrontY[i] += 2;
                if (sniegFrontY[i] > ClientSize.Height)
                {
                    sniegFrontX[i] = rng.Next(ClientSize.Width);
                    sniegFrontY[i] = 0;
                    transparencyF[i] = 100;
                }
                transparencyF[i] = vanishing(transparencyF[i]);
                Invalidate();
            }

            for (int i = 0; i < sniegBack; i++)
            {
                sniegBackX[i] += 1;
                if (sniegBackX[i] > ClientSize.Width)
                {
                    sniegBackX[i] = 0;
                    sniegBackY[i] = rng.Next(ClientSize.Height);
                    transparencyB[i] = 100;
                }

                sniegBackY[i] += 1;
                if (sniegBackY[i] > ClientSize.Height)
                {
                    sniegBackX[i] = rng.Next(ClientSize.Width);
                    sniegBackY[i] = 0;
                    transparencyB[i] = 100;
                }
                Invalidate();
            }
        }

        private void drawTree(int x, int y, PaintEventArgs e)
        {
            Point[] part1 = { new Point(x, y - 100), new Point(x - 100, y), new Point(x + 100, y) };
            Point[] part2 = { new Point(x, y - 130), new Point(x - 80, y - 50), new Point(x + 80, y - 50) };
            Point[] part3 = { new Point(x, y - 160), new Point(x - 60, y - 100), new Point(x + 60, y - 100) };

            g.FillPolygon(Brushes.DarkGreen, part1);
            g.FillPolygon(Brushes.Green, part2);
            g.FillPolygon(Brushes.ForestGreen, part3);
            g.FillRectangle(Brushes.SaddleBrown, x - 5, y, 10, 40);
         }

        private void drawBalwan(int x, int y, PaintEventArgs e)
        {
            SolidBrush balwan = new SolidBrush(Color.WhiteSmoke);

            g.FillEllipse(balwan, x, y, 80, 70);
            g.FillEllipse(balwan, x+10, y-40, 60, 50);
            g.FillEllipse(balwan, x + 20, y - 70, 40, 40);

            g.FillEllipse(Brushes.Black, x + 38, y - 60, 5, 5);
            g.FillEllipse(Brushes.Black, x + 50, y - 60, 5, 5);

            g.FillPie(Brushes.OrangeRed, x+45, y-80, 80, 80, 180, 12); 
        }

        private void drawSniegFront(PaintEventArgs e)
        {
            Color kolor = Color.FromArgb(100, Color.White);
            for (int i = 0; i < sniegFront; i++)
            {
                kolor = Color.FromArgb(transparencyF[i], Color.White);
                g.FillEllipse(new SolidBrush(kolor), sniegFrontX[i], sniegFrontY[i], 5, 5);
            }
        }

        private void drawSniegBack(PaintEventArgs e)
        {
            Color kolor2 = Color.FromArgb(100, Color.White);
            for (int i = 0; i < sniegBack; i++)
            {
                kolor2 = Color.FromArgb(transparencyB[i], Color.White);
                g.FillEllipse(new SolidBrush(kolor2), sniegBackX[i], sniegBackY[i], 2, 2);
            }
        }

        private int vanishing(int _t)
        {
            if (rng.Next(10) == znikanieSzansa && _t > 10) _t -= 10;
            return _t;
        }

        private void InitializeSnow()
        {
            sniegFrontX = new int[sniegFront];
            sniegFrontY = new int[sniegFront];
            transparencyF = new int[sniegFront];

            for (int i = 0; i < sniegFront; i++)
            {
                sniegFrontX[i] = rng.Next(ClientSize.Width);
                sniegFrontY[i] = rng.Next(ClientSize.Height);
                transparencyF[i] = 100;
            }

            sniegBackX = new int[sniegBack];
            sniegBackY = new int[sniegBack];
            transparencyB = new int[sniegBack];

            for (int i = 0; i < sniegBack; i++)
            {
                sniegBackX[i] = rng.Next(ClientSize.Width);
                sniegBackY[i] = rng.Next(ClientSize.Height);
                transparencyB[i] = 100;
            }
        }
    }
}
