using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AsystentZakupow.Model
{
    public class Sumator
    {
        public decimal Limit { get; private set; }
        public decimal Suma { get; set; }

        public Sumator(decimal suma, decimal limit)
        {
            if (suma < limit && limit > 0)
            {
                Suma = suma;
                Limit = limit;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Sumator wrong value exception.");
            }
        }
    }
}
