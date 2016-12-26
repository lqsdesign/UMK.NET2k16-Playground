using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjectMoon
{
    public abstract class Planet
    {
        public int Mass { get; set; }
        public int Distance { get; set; }
        public int Y { get; set; }

        public void CalculateDistance(Lunar1 ship)
        {
            Distance = this.Y - ship.StartPoint.Y - ship.SpaceHight;
        }

        public void MovePlanet(double _speed)
        {
            this.Y -= (int)_speed;
        }
    }
}
