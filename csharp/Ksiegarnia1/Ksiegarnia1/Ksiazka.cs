using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksiegarnia1
{
    public abstract class Ksiazka
    {
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public uint Ilosc { get; set; }

        public Ksiazka(string _tytul, string _autor, uint _ilosc)
        {
            this.Tytul = _tytul;
            this.Autor = _autor;
            this.Ilosc = _ilosc;
        }

        public void SprzedajKsiazke()
        {
            try
            {
                if (this.Ilosc == 0) throw new Exception();
                this.Ilosc--;
                Console.WriteLine("Ksiazka sprzedana");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ksiazka niedostepna!");
                //Console.WriteLine(ex.Message);    
            }


            /*if (this.Ilosc == 0)
            {
                Console.WriteLine("Ksiazka niedostepna!");
            }
            else
            {
                this.Ilosc--;
                Console.WriteLine("Sprzedano: {0}", this.Tytul);
            } */
        }

    }
}
