using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjectMoon
{
    public abstract class SpaceShip
    {
        public int Fuel { get; set; }
        public double Speed { get; set; }
        public double EnginePower { get; set; }
        public int Mass { get; set; }
        public Point StartPoint { get; set; }
        public int SpaceWidth { get; set; }
        public int SpaceHight { get; set; }
        public void StartEngine()
        {
            if (this.Fuel > 0)
            {
                this.Speed -= this.EnginePower;
                this.Mass--;
                this.Fuel--;
            }
        }

    }
}
