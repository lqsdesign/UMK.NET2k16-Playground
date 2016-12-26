using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMoon
{
    public class StarsBG
    {
        public int[] positionX { get; set; }
        public int[] positionY { get; set; }
        public int[] opacity { get; set; }
        public int density { get; set; }

        static Random rng = new Random();

        public StarsBG(int _density = 500, int _width = 800, int _height = 600)
        {
            InitializeStars(_density, _width, _height);

        }

        private void InitializeStars(int _density, int width, int height)
        {
            density = _density;

            positionX = new int[density];
            positionY = new int[density];
            opacity = new int[density];          

            for (int i = 0; i < density; i++)
            {
                positionX[i] = rng.Next(width);
                positionY[i] = rng.Next(height);
                opacity[i] = rng.Next(200);
            }
        }

        public void MoveStars(Lunar1 ship, int width, int height, int speed = 2)
        {
            for (int i = 0; i < density; i++)
            {
                positionY[i] -= (int)ship.Speed / speed;
            }

            for (int i = 0; i < density; i++)
            {
                if (positionY[i] < 0)
                {
                    positionY[i] = height;
                    positionX[i] = rng.Next(width);
                    opacity[i] = rng.Next(200);
                }
                else if (positionY[i] > height)
                {
                    positionY[i] = 0;
                    positionX[i] = rng.Next(width);
                    opacity[i] = rng.Next(200);
                }


            }
        }


    }
}
