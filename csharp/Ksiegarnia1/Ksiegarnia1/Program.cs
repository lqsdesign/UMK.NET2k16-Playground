using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksiegarnia1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Edukacyjne> ksiazkiEdukacyjne = new List<Edukacyjne>
            {
                new Edukacyjne("Matematyka 1", "Stefan", 5, 1, "Matematyka"),
                new Edukacyjne("Matematyka 2", "Ziutek", 2, 2, "Matematyka")
            };


            Console.WriteLine("Ksiazka: {0}({1})", ksiazkiEdukacyjne[0].Tytul, ksiazkiEdukacyjne[0].Ilosc);
            ksiazkiEdukacyjne[0].Ilosc++;
            Console.WriteLine("Ksiazka: {0}({1})", ksiazkiEdukacyjne[0].Tytul, ksiazkiEdukacyjne[0].Ilosc);

            ksiazkiEdukacyjne[1].SprzedajKsiazke();
            ksiazkiEdukacyjne[1].SprzedajKsiazke();
            ksiazkiEdukacyjne[1].SprzedajKsiazke();


            Console.ReadKey();
        }
    }
}
