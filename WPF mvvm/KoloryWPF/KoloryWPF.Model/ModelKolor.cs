using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//komentarz na potrzeby testu github-sourcetree
namespace KoloryWPF.Model
{
    public class ModelKolor
    {
        public byte R { get; private set; }
        public byte G { get; private set; }
        public byte B { get; private set; }

        public byte[] RGB
        {
            get
            {
                return new byte[3] { this.R, this.G, this.B };
            } 
        }

        public ModelKolor(byte _r, byte _g, byte _b)
        {
            this.R = _r;
            this.G = _g;
            this.B = _b;
        }

        public void SetColor(char _color, byte _value)
        {
            switch (_color)
            {
                case 'R':
                    this.R = _value;
                    break;
                case 'G':
                    this.B = _value;
                    break;
                case 'B':
                    this.B = _value;
                    break;
                default:
                    throw new InvalidOperationException("Invalid color type - method SetColor");
            }
        }

    }
}
