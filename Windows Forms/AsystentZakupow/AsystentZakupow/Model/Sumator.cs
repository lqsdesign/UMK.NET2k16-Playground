using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsystentZakupow.Model
{
    public class Sumator
    {
        decimal suma = 0;
        decimal limit = 100;
        public void DodajKwote(decimal kwota)
        {
            if (suma + kwota > limit) throw new ArgumentOutOfRangeException("Limit przekroczony");
            suma += kwota;
        }

        public Sumator(decimal _suma = 0, decimal _limit = 100)
        {
            this.suma = _suma;
            this.limit = _limit;
        }

        public decimal Suma
        {
            get { return suma; }
        }

        public decimal Limit
        {
            get { return limit; }
        }
    }
}
