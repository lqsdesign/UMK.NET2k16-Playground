using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    public class Car
    {
        public string model { get; set; }
        public string marka { get; set; }
        public uint rocznik { get; set; }

        public override string ToString()
        {
            return String.Format("{0}-{1}-({2})", marka, model, rocznik);
        }



    }
}
