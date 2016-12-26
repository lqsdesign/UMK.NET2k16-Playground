using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Rectangle : Drawable
    {
        private int height;
        private int width;

        public Rectangle(int _w, int _h)
        {
            if (_w <= 0 || _h <= 0)
            {
                throw new ArgumentException("Wymiar musi być większy od zera");            
            }
            height = _h;
            width = _w;
        }

        public override void Draw()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++) Console.Write(drawChar);

                Console.WriteLine();
            }
        }
    }
}
