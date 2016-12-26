using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjectMoon
{
    public class Lunar1:SpaceShip
    {
        private void Initialize()
        {
            this.Fuel = 200;
            this.Mass = 3200;
            this.EnginePower = 0.5;
            this.Speed = 20;
            this.StartPoint = new Point(200, 200);
            this.SpaceWidth = 50;
            this.SpaceHight = 50;
        }

        public Lunar1()
        {
            Initialize();
        }
    }
}
