using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Ksiazka
    {
        public int Id { get; set; }
        public string tytul { get; set; }
        public string autor { get; set; }
        public string  wydawnictwo { get; set; }
        public DateTime rokWydania { get; set; }
        public int sprzedanych { get; set; }

        public override string ToString()
        {
            return String.Format($"[{ Id}] T: {tytul} | A: {autor} | W: {wydawnictwo}, Rok: {rokWydania.Year} | Sprz: {sprzedanych}");
        }
    }
}
