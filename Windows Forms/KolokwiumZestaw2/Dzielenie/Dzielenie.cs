using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dzielenie
{
    public static class Dzielenie
    {
        public static double Podziel(double dzielna, double dzielnik)
        {
            if (dzielnik == 0) throw new Exception("Dzielnik jest zerem");

            return dzielna/dzielnik;
        }
    }
}
