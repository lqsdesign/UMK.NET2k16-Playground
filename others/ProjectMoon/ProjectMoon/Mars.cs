using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjectMoon
{
    class Mars : Planet
    {
        private void Initialize(int _mass, int _Y)
        {
            this.Mass = _mass;
            this.Distance = 0;
            this.Y = _Y;
            
        }
        public Mars(int _mass = 32000, int _Y = 800)
        {
            Initialize(_mass, _Y);
        }
    }
}
