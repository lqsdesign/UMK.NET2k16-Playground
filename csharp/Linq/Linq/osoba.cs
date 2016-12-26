using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class osoba
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public int NumerTel { get; set; }

        public override string ToString()
        {
            return Imie + " " + Nazwisko + " (" + Wiek + ")";
        }
    }
}
