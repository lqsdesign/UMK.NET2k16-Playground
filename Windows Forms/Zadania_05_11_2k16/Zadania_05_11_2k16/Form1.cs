using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadania_05_11_2k16
{
    public partial class Form1 : Form
    {
        Graphics g;
        double time = 0.7;
        double speed = 0.5;
        int cloudQty = 1;
        int[] cloud_X, cloud_Y, cloud_W, cloud_T;
       
        public Form1()
        {
            InitializeComponent();
            InitializeClouds();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void InitializeClouds()
        {
            cloud_X = new int[100];
            cloud_Y = new int[100];
            cloud_W = new int[100];
            cloud_T = new int[100];

            for (int i = 0; i < 100; i++)
            {
                cloud_X[i] = 232;
                cloud_Y[i] = 264;
                cloud_W[i] = 10;
                cloud_T[i] = 0;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            //int y = 264 - (int)Math.Round(speed * time);

            
            //int x = 232 + (int)(Math.Sin((264 - y)/10) * 3);

            //int w = 10 + (int)Math.Round(time * 0.1);
            paintHouse2();
            //paintCloudPart(w, w, x, y);
            //if (y < 0) time = 0;
            for (int i = 0; i < cloudQty; i++)
            {
                paintCloudPart(cloud_W[i], cloud_W[i], cloud_X[i], cloud_Y[i]);
            }
        }

        private void paintHouse2()
        {
            #region ground
            Point[] grass = {
                new Point(132, 465),
                new Point(293, 370),
                new Point(450, 465),
                new Point(291, 556)
            };
            #endregion
            #region wall
            Point[] wall_1 = {
                new Point(178, 465),
                new Point(178, 344),
                new Point(219, 317),
                new Point(292, 432),
                new Point(292, 531)
            };

            Point[] wall_2 = {
                new Point(292, 531),
                new Point(292, 432),
                new Point(407, 365),
                new Point(407, 465)
            };
            #endregion
            #region roof
            Point[] roof_edge = {
                new Point(164, 363),
                new Point(160, 358),
                new Point(217, 315),
                new Point(292, 434),
                new Point(285, 437),
                new Point(214, 326)
            };

            Point[] roof_main = {
                new Point(292, 434),
                new Point(217, 315),
                new Point(348, 240),
                new Point(423, 359)
            };
            #endregion
            #region chimney
            Point[] chimney_1 = {
                new Point(222, 314),
                new Point(222, 272),
                new Point(238, 282),
                new Point(238, 305)
            };
            Point[] chimney_2 = {
                new Point(238, 305),
                new Point(238, 282),
                new Point(255, 272),
                new Point(255, 303)
            };
            Point[] chimney_3 = {
                new Point(222, 272),
                new Point(238, 262),
                new Point(255, 272),
                new Point(238, 282)
            };
            Point[] chimney_4 = {
                new Point(229, 272),
                new Point(239, 265),
                new Point(249, 272),
                new Point(239, 278)
            };
            #endregion
            #region door
            Point[] door_1 = {
                new Point(196, 466),
                new Point(196, 403),
                new Point(221, 417),
                new Point(221, 480)
            };
            Point[] door_2 = {
                new Point(203, 442),
                new Point(203, 437),
                new Point(214, 443),
                new Point(214, 448)
            };
            #endregion
            #region window1
            Point[] window1_1 = {
                new Point(240, 468),
                new Point(240, 425),
                new Point(265, 440),
                new Point(265, 483)
            };
            Point[] window1_2 = {
                new Point(240, 468),
                new Point(240, 425),
                new Point(245, 439),
                new Point(245, 479)
            };
            Point[] window1_3 = {
                new Point(265, 440),
                new Point(265, 483),
                new Point(251, 483),
                new Point(251, 440)
            };
            #endregion
            #region window2
            Point[] window2_1 = {
                new Point(319, 486),
                new Point(319, 444),
                new Point(342, 429),
                new Point(342, 471)
            };
            Point[] window2_2 = {
                new Point(319, 486),
                new Point(319, 444),
                new Point(329, 458),
                new Point(329, 498)
            };
            Point[] window2_3 = {
                new Point(342, 429),
                new Point(342, 471),
                new Point(360, 471),
                new Point(360, 429)
            };
            #endregion
            #region window3
            Point[] window3_1 = {
                new Point(372, 455),
                new Point(372, 414),
                new Point(395, 400),
                new Point(395, 440)
            };
            Point[] window3_2 = {
                new Point(372, 455),
                new Point(372, 414),
                new Point(388, 414),
                new Point(388, 455)
            };
            Point[] window3_3 = {
                new Point(395, 440),
                new Point(395, 400),
                new Point(404, 410),
                new Point(404, 450)
            };
            #endregion
            #region sky
            Point[] sky = {
                new Point(0,0),
                new Point(600, 0),
                new Point(600, 80),
                new Point(0, 80)
            };
            #endregion
            g.FillPolygon(Brushes.LawnGreen, grass);

            g.FillPolygon(Brushes.White, wall_1);
            g.DrawPolygon(Pens.Black, wall_1);
            g.FillPolygon(Brushes.WhiteSmoke, wall_2);
            g.DrawPolygon(Pens.Black, wall_2);

            g.FillPolygon(Brushes.DarkRed, chimney_1);
            g.DrawPolygon(Pens.Black, chimney_1);
            g.FillPolygon(Brushes.Red, chimney_2);
            g.DrawPolygon(Pens.Black, chimney_2);
            g.FillPolygon(Brushes.DarkRed, chimney_3);
            g.DrawPolygon(Pens.Black, chimney_3);
            g.FillPolygon(Brushes.Black, chimney_4);

            g.FillPolygon(Brushes.DarkRed, roof_edge);
            g.DrawPolygon(Pens.Black, roof_edge);
            g.FillPolygon(Brushes.Red, roof_main);
            g.DrawPolygon(Pens.Black, roof_main);

            g.FillPolygon(Brushes.Brown, door_1);
            g.DrawPolygon(Pens.Black, door_1);
            g.FillPolygon(Brushes.Black, door_2);

            g.FillPolygon(Brushes.CadetBlue, window1_1);
            g.DrawPolygon(Pens.Black, window1_1);
            g.FillPolygon(Brushes.Brown, window1_2);
            g.DrawPolygon(Pens.Black, window1_2);
            g.FillPolygon(Brushes.Brown, window1_3);
            g.DrawPolygon(Pens.Black, window1_3);

            g.FillPolygon(Brushes.CadetBlue, window2_1);
            g.DrawPolygon(Pens.Black, window2_1);
            g.FillPolygon(Brushes.Brown, window2_2);
            g.DrawPolygon(Pens.Black, window2_2);
            g.FillPolygon(Brushes.Brown, window2_3);
            g.DrawPolygon(Pens.Black, window2_3);

            g.FillPolygon(Brushes.CadetBlue, window3_1);
            g.DrawPolygon(Pens.Black, window3_1);
            g.FillPolygon(Brushes.Brown, window3_2);
            g.DrawPolygon(Pens.Black, window3_2);
            g.FillPolygon(Brushes.Brown, window3_3);
            g.DrawPolygon(Pens.Black, window3_3);

            g.FillPolygon(Brushes.LightGray, sky);
        }

        private void paintCloudPart(int _w, int _h, int _x, int _y)
        {
            g.FillEllipse(Brushes.LightGray, _x, _y, _w, _h);
        }

        private void resetCloud(int _i)
        {
            cloud_X[_i] = 232;
            cloud_Y[_i] = 264;
            cloud_W[_i] = 10;
            cloud_T[_i] = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time += timer1.Interval / 5;

            for (int i = 0; i < cloudQty; i++)
            {
                //cloud_Y[i] = cloud_Y[i] - (int)Math.Round(speed * time);
                cloud_X[i] += (int)(Math.Sin((264 - cloud_Y[i]) / 10) * 2);
                //cloud_W[i] = cloud_W[i] + (int)Math.Round((double)cloud_T[i]/100);

                cloud_Y[i] -= 2;
                cloud_T[i] += 1;
                if (cloud_Y[i] < 0) resetCloud(i);
            }

            cloudQty++;
            if (cloudQty > 100) cloudQty = 100;
            Invalidate();
        }
    }
}
