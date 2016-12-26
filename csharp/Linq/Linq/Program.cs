using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        #region deklaracjaListy
        static List<osoba> listaOsob = new List<osoba>
        {
            new osoba
            {
                Id = 1,
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Wiek = 28,
                NumerTel = 88458856
            },
            new osoba
            {
                Id = 2,
                Imie = "Tomek",
                Nazwisko = "Kowalski",
                Wiek = 31,
                NumerTel = 23424323
            },
            new osoba
            {
                Id = 3,
                Imie = "Anna",
                Nazwisko = "Nijaka",
                Wiek = 17,
                NumerTel = 65654442
            },
            new osoba
            {
                Id = 4,
                Imie = "Jan",
                Nazwisko = "Nowak",
                Wiek = 15,
                NumerTel = 5433244
            },
            new osoba
            {
                Id = 5,
                Imie = "Jola",
                Nazwisko = "Kowalska",
                Wiek = 51,
                NumerTel = 7788467
            },
            new osoba
            {
                Id = 6,
                Imie = "Patryk",
                Nazwisko = "Kowalski",
                Wiek = 20,
                NumerTel = 6589923
            }
        };
        #endregion
        static void Main(string[] args)
        {
            //var kolekcjaOsobPelnoletnich = from osoba in listaOsob where osoba.Wiek >= 18 orderby osoba.Wiek select osoba;
            var kolekcjaOsobPelnoletnich = listaOsob.Where(x => x.Wiek >= 18).OrderBy(x=>x.Wiek).ThenBy(x=>x.Imie);
            var najstarszaOsoba = listaOsob.Max(x => x.Wiek);

            // (argumenty) => (wyrazenie) np: (x,y) => x+y 
            WyswietlListeOsob(kolekcjaOsobPelnoletnich);
            //Console.WriteLine("wiek najstarszej osoby: " + najstarszaOsoba.ToString());
            //Console.WriteLine("wiek najmłodszej osoby: " + listaOsob.Min(x => x.Wiek));

            //Console.WriteLine("Srednia wieku: " + listaOsob.Average(x=>x.Wiek));
            //Console.WriteLine("Suma wieku: " + listaOsob.Sum(x => x.Wiek));

            string zdanie = "Ala ma kota, kot ma Ale";
            var wyrazy = zdanie.Split(' ');
            Console.WriteLine("Odwrotnie: " + wyrazy.Aggregate((x, y) => y + " " + x));

            Console.WriteLine("Pierwsza osoba pelnoletnia: " + kolekcjaOsobPelnoletnich.First());

            Console.WriteLine("Element o indeksie 2: " + kolekcjaOsobPelnoletnich.ElementAt(1));

            Console.WriteLine("Czy osoby pelnoletnie? " + listaOsob.All(x => x.Wiek >= 18));
            Console.WriteLine("Czy osoby niepelnoletnie? " + listaOsob.Any(x=>x.Wiek < 18));

            //var grupaOsobOTymSamymNazwisku = from osoba in listaOsob
            //group osoba by osoba.Nazwisko into grupa
            //select grupa;
            var grupaOsobOTymSamymNazwisku = listaOsob.GroupBy(x => x.Nazwisko);

            Console.WriteLine("Pogrupowane osoby: ");
            foreach (var grupa in grupaOsobOTymSamymNazwisku)
            {
                Console.WriteLine("Grupa osob o nazwisku: " + grupa.Key);
                foreach (var osoba in grupa) Console.WriteLine(osoba.Imie + " " + osoba.Nazwisko);
                Console.WriteLine();
            }

            var kolekcjaOsobPelnoletnich2 = from osoba in listaOsob
                                            where osoba.Wiek >= 18
                                            orderby osoba.Wiek
                                            select new { osoba.Imie, osoba.Nazwisko, osoba.Wiek };
            var kolekcjaKobiet = from osoba in listaOsob
                                 where osoba.Imie.EndsWith("a")
                                 select new { osoba.Imie, osoba.Nazwisko, osoba.Wiek };

            //var listaPelnoletnichLubKobiet = kolekcjaOsobPelnoletnich2.Concat(kolekcjaKobiet).Distinct(); //polaczenie kolekcji, nie sprawdza distinct
            var listaPelnoletnichLubKobiet = kolekcjaOsobPelnoletnich2.Union(kolekcjaKobiet); //polaczenie bez powtarzajacych

            var listaPelnoletnichKobiet = kolekcjaOsobPelnoletnich2.Intersect(kolekcjaKobiet); //czesc wspolna obu kolekcji

            var listaPelnoletnichMezczyzn = kolekcjaOsobPelnoletnich2.Except(kolekcjaKobiet); //kolekcja pierwsza pomniejszona o elementy z kolekcji drugiej


            //rozne typy
            var listaTelefonow = from osoba in listaOsob
                                 select new { osoba.Id, osoba.NumerTel };

            var listaPersonaliow = from osoba in listaOsob
                                   select new { osoba.Id, osoba.Imie, osoba.Nazwisko };

            var listaPersonaliowZTelefonami = from telefon in listaTelefonow
                                              join personalia in listaPersonaliow
                                              on telefon.Id equals personalia.Id
                                              select new
                                              {
                                                  telefon.Id,
                                                  personalia.Nazwisko,
                                                  telefon.NumerTel
                                              };

            var listaPersonaliowZTelefonami2 = listaTelefonow.Join(listaPersonaliow,
                x => x.Id,
                y => y.Id,
                (x, y) => new { x.Id, y.Imie, y.Nazwisko, x.NumerTel });


            //nowa lista
            var nowaKolekcjaOsobPelnoletnich = from osoba in listaOsob
                                               where osoba.Wiek >= 18
                                               orderby osoba.Wiek
                                               select new osoba
                                               {
                                                   Id = osoba.Id,
                                                   Imie = osoba.Imie,
                                                   Nazwisko = osoba.Nazwisko,
                                                   Wiek = osoba.Wiek,
                                                   NumerTel = osoba.NumerTel
                                               }; //sprawdzic to jeszcze 


            Console.WriteLine("Przed zmiana: " + nowaKolekcjaOsobPelnoletnich.First().ToString());
            nowaKolekcjaOsobPelnoletnich.First().Imie = "Lukasz";
            nowaKolekcjaOsobPelnoletnich.First().Wiek = 28;

            Console.WriteLine("Po zmianie: " + nowaKolekcjaOsobPelnoletnich.First().ToString());

            
            Console.WriteLine(Kata.CountPositivesSumNegatives(null)[0]);
            Console.WriteLine(Kata.CountPositivesSumNegatives(null)[1]);
            Console.ReadKey();
        }

        static void WyswietlListeOsob(IEnumerable<osoba> lista)
        {
            foreach (var osoba in lista)
            {
                Console.WriteLine(osoba.ToString());
            }
        }


    }
}
