using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksTODO.Model
{
    public enum PriorytetZadania : byte { Mniejwazne, Wazne, Krytyczne};
    public class Zadanie
    {
        public string Opis { get; private set; }
        public DateTime DataUtworzenia { get; private set; }
        public DateTime PlanowanaDataRealizacji { get; private set; }
        public PriorytetZadania Priorytet { get; private set; }
        public bool CzyZrealizowane { get; set; }

        public Zadanie(string opis, DateTime dataUtworzenia, DateTime planowanaDataRealizacji, PriorytetZadania priorytet, bool czyZrealizowane)
        {
            Opis = opis;
            DataUtworzenia = dataUtworzenia;
            PlanowanaDataRealizacji = planowanaDataRealizacji;
            Priorytet = priorytet;
            CzyZrealizowane = czyZrealizowane;
        }

        public override string ToString()
        {
            return Opis;
        }
    }
}
