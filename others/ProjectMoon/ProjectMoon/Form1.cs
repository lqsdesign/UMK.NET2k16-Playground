using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMoon
{
    public partial class Form1 : Form
    {
        Graphics g;
        Lunar1 space1;
        StarsBG stars, starsFront;
        Mars mars;
        bool engineOn = false;
        public Form1()
        {
            InitializeComponent();
            space1 = new Lunar1();
            SpacePositionInitialize(space1);

            stars = new StarsBG(50, ClientSize.Width, ClientSize.Height);
            starsFront = new StarsBG(50, ClientSize.Width, ClientSize.Height);

            mars = new Mars(30000, 2000);
            mars.CalculateDistance(space1);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            DrawStars(stars, e);
            DrawStars(starsFront, e, 4);
            DrawShipLunar1(space1, e);
            if (engineOn) DrawEngineFire(space1, e);
            DrawParameters(space1);
            DrawPlanetGround(mars, e);
            
        }

        private void DrawShipLunar1(Lunar1 ship, PaintEventArgs e)
        {
            int topCut = 10;
            Point[] capsule = { new Point(ship.StartPoint.X+topCut, ship.StartPoint.Y),
                                new Point(ship.StartPoint.X + ship.SpaceWidth - topCut, ship.StartPoint.Y),
                                new Point(ship.StartPoint.X + ship.SpaceWidth, ship.StartPoint.Y+ship.SpaceHight),
                                new Point(ship.StartPoint.X, ship.StartPoint.Y+ship.SpaceHight)};
            g.FillPolygon(Brushes.Gray, capsule);
            g.FillEllipse(Brushes.DarkSlateBlue, ship.StartPoint.X + (int)ship.SpaceWidth / 3, ship.StartPoint.Y + (int)ship.SpaceHight / 3, (int)ship.SpaceWidth / 3, (int)ship.SpaceHight / 3);
           
        }

        private void DrawEngineFire(Lunar1 ship, PaintEventArgs e)
        {
            int fireCut = 10;
            Color backFire = Color.FromArgb(50, Color.OrangeRed);
            Point[] FirePoint = { new Point(ship.StartPoint.X + fireCut, ship.StartPoint.Y+ship.SpaceHight), new Point(ship.StartPoint.X+ship.SpaceWidth - fireCut, ship.StartPoint.Y + ship.SpaceHight), new Point(ship.StartPoint.X + (int)ship.SpaceWidth/2, ship.StartPoint.Y + ship.SpaceHight*2) };
            Point[] fireB1 = { new Point(ship.StartPoint.X, ship.StartPoint.Y + ship.SpaceHight),
                               new Point(ship.StartPoint.X + ship.SpaceWidth - fireCut, ship.StartPoint.Y + ship.SpaceHight), 
                               new Point(ship.StartPoint.X- (int)ship.SpaceWidth/2, ship.StartPoint.Y + (int)(ship.SpaceHight*1.5))};
            Point[] fireB2 = { new Point(ship.StartPoint.X + fireCut, ship.StartPoint.Y + ship.SpaceHight),
                               new Point(ship.StartPoint.X + ship.SpaceWidth, ship.StartPoint.Y + ship.SpaceHight),
                               new Point(ship.StartPoint.X + ship.SpaceWidth + (int)ship.SpaceWidth/2, ship.StartPoint.Y + (int)(ship.SpaceHight*1.5))};

            if (space1.Fuel != 0)
            {
                g.FillPolygon(new SolidBrush(backFire), fireB1);
                g.FillPolygon(new SolidBrush(backFire), fireB2);
                g.FillPolygon(Brushes.OrangeRed, FirePoint);
            }
            
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            stars.MoveStars(space1, ClientSize.Width, ClientSize.Height);
            starsFront.MoveStars(space1, ClientSize.Width, ClientSize.Height, 20);

            mars.MovePlanet(space1.Speed);
            mars.CalculateDistance(space1);

            gravity(space1, mars);

            Refresh();
            Collision(space1, mars);
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                engineOn = true;
                space1.StartEngine();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            engineOn = false;
        }

        private void SpacePositionInitialize(Lunar1 ship)
        {
            ship.StartPoint = new Point((int)ClientSize.Width / 2 - (int)ship.SpaceWidth / 2, (int)ClientSize.Height / 2 - (int)ship.SpaceHight / 2);
        }
        private void DrawParameters(Lunar1 ship)
        {
            Speed.Text = space1.Speed.ToString();
            Mass.Text = space1.Mass.ToString();
            Fuel.Text = space1.Fuel.ToString();
            Attitude.Text = mars.Distance.ToString();
        }

        private void DrawStars(StarsBG _stars, PaintEventArgs e, int size = 2)
        {
            Color kolor = Color.FromArgb(100, Color.White);
            
            for (int i = 0; i < _stars.density; i++)
            {
                kolor = Color.FromArgb(_stars.opacity[i], Color.White);
                g.FillEllipse(new SolidBrush(kolor), _stars.positionX[i], _stars.positionY[i], size, size);
            }
        }

        private void DrawPlanetGround(Mars _mars, PaintEventArgs e)
        {
            g.FillRectangle(Brushes.LightGray, 0, _mars.Y, ClientSize.Width, 300);
        }

        private void gravity(Lunar1 _ship, Mars _mars)
        {
            _ship.Speed += 0.05;
        }

        private void Collision(Lunar1 _ship, Mars _mars)
        {
            if (_mars.Distance < 0)
            {
                timer1.Enabled = false;
                if (_ship.Speed < 2)
                {
                    MessageBox.Show("WIN", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("LOSE", "Lose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
