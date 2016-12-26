using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Program
    {
        #region deklaracjaCars
        private static List<Car> samochody = new List<Car>
            {
                new Car
                {
                    marka = "Honda",
                    model = "Civic",
                    rocznik = 2000
                },
                new Car
                {
                    marka = "Audi",
                    model = "Q7",
                    rocznik = 2016
                },
                new Car
                {
                    marka = "Honda",
                    model = "S2000",
                    rocznik = 2004
                },
                new Car
                {
                    marka = "Opel",
                    model = "Corsa",
                    rocznik = 1995
                },
                new Car
                {
                    marka = "Toyota",
                    model = "Corolla",
                    rocznik = 2009
                }
            };
        #endregion
        static void Main(string[] args)
        {
            var autaPonizej2000 = samochody.Where(x => x.rocznik <= 2000).OrderBy(x => x.rocznik);
            var autaMaks5letnie = samochody.Where(x => x.rocznik > 2011).OrderBy(x => x.marka);
            var autaHonda = samochody.Where(x => x.marka == "Honda");
            var autaNieHonda = samochody.Where(x => x.marka != "Honda");
            var autoNajstarsze = samochody.Min(x => x.rocznik);
            var autoNajmlodsze = samochody.Max(x => x.rocznik);

            Console.WriteLine("Auto najstarsze: " + autoNajstarsze);
            Console.WriteLine("Auto najmlodsze: " + autoNajmlodsze);

            Console.WriteLine("--- Samochody z 2000 i starsze:");
            foreach (Car car in autaPonizej2000)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine("--- Samochody maksymalnie 5 letnie");
            foreach (Car car in autaMaks5letnie)
            {
                Console.WriteLine(car.ToString());
            }
            Console.WriteLine("--- HONDA! ---");
            foreach (Car car in autaHonda)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine("--- FOREACH STRING! ---");
            string test = "anakonda";
            foreach (char c in test)
            {
                if (c == 'a') Console.WriteLine("Znalazlem a");
            }

            string zdanie = "Ala ma kota i duze cycki";
            //Array wyrazy = zdanie.Split(' ');
            foreach (string s in zdanie.Split(' '))
            {
                Console.WriteLine((s == "kota") ? "Znalazlem" : "nie znalazlem");
            }

            Console.ReadKey();
        }
    }
}
