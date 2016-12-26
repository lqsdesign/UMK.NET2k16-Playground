using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksiegarnia1
{
    public class Edukacyjne: Ksiazka
    {
        public int klasa {get; set;}
        public string przedmiot { get; set; }
        public Edukacyjne(string _t, string _a, uint _i, int _k, string _p) : base(_t, _a, _i)
        {
            this.klasa = _k;
            this.przedmiot = _p;
        }
    }
}
