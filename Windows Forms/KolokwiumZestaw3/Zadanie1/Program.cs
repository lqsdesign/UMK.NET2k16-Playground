using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        #region kolekcja
        static List<Ksiazka> kolekcjaKsiazek = new List<Ksiazka>
        {
            new Ksiazka
            {
                Id = 1,
                tytul = "Ksiazka 1",
                autor = "Autor 1",
                wydawnictwo = "Wydawnictwo 1",
                rokWydania = new DateTime(2000, 5, 12),
                sprzedanych = 15
            },
            new Ksiazka
            {
                Id = 2,
                tytul = "Ksiazka 2",
                autor = "Autor 1",
                wydawnictwo = "Wydawnictwo 1",
                rokWydania = new DateTime(2002, 1, 1),
                sprzedanych = 26
            },
            new Ksiazka
            {
                Id = 3,
                tytul = "Ksiazka 3",
                autor = "Autor 1",
                wydawnictwo = "Wydawnictwo 2",
                rokWydania = new DateTime(2003, 3, 1),
                sprzedanych = 254
            },
            new Ksiazka
            {
                Id = 4,
                tytul = "Ksiazka 4",
                autor = "Autor 2",
                wydawnictwo = "Wydawnictwo 1",
                rokWydania = new DateTime(2011, 5, 20),
                sprzedanych = 65
            },
            new Ksiazka
            {
                Id = 5,
                tytul = "Ksiazka 5",
                autor = "Kowalski",
                wydawnictwo = "Wydawnictwo 1",
                rokWydania = new DateTime(2012, 1, 20),
                sprzedanych = 220
            },
            new Ksiazka
            {
                Id = 6,
                tytul = "Ksiazka 6",
                autor = "Autor 3",
                wydawnictwo = "Wydawnictwo 2",
                rokWydania = new DateTime(2015, 12, 20),
                sprzedanych = 190
            },
            new Ksiazka
            {
                Id = 7,
                tytul = "Ksiazka 7",
                autor = "Autor 3",
                wydawnictwo = "Wydawnictwo 3",
                rokWydania = new DateTime(2000, 5, 20),
                sprzedanych = 521
            },
            new Ksiazka
            {
                Id = 8,
                tytul = "Ksiazka 8",
                autor = "Kowalski",
                wydawnictwo = "Wydawnictwo 3",
                rokWydania = new DateTime(1999, 1, 20),
                sprzedanych = 58
            },
            new Ksiazka
            {
                Id = 9,
                tytul = "Ksiazka 9",
                autor = "Kowalski",
                wydawnictwo = "Wydawnictwo 3",
                rokWydania = new DateTime(1980, 12, 8),
                sprzedanych = 1500
            },
            new Ksiazka
            {
                Id = 10,
                tytul = "Ksiazka 10",
                autor = "Autor 4",
                wydawnictwo = "Wydawnictwo 4",
                rokWydania = new DateTime(2016, 12, 2),
                sprzedanych = 5
            }
        };
        #endregion

        static void Main(string[] args)
        {

            var ksiazkiWydanePrzed2000 = kolekcjaKsiazek.Where(x => x.rokWydania.Year < 2000);

            Console.WriteLine("a. wyświetl wszystkie książki, które zostały wydane przed rokiem 2010");
            foreach (Ksiazka k in ksiazkiWydanePrzed2000)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine();
            Console.WriteLine("b. pogrupuj wszystkie książki po wydawnictwie");

            foreach (var temp in kolekcjaKsiazek.GroupBy(x => x.wydawnictwo).Select(x => new { x.Key, x }))
            {
                Console.WriteLine("Wydawnictwo: {0}", temp.Key);
                foreach (Ksiazka k in temp.x)
                {
                    Console.WriteLine(k);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("c.wyświetl książkę, która ma najwięcej sprzedanych egzemplarzy");

            var bestseller = kolekcjaKsiazek.OrderBy(x=>x.sprzedanych).Last();
            Console.WriteLine(bestseller);

            Console.WriteLine();
            Console.WriteLine("stwórz dwie kolekcje:");
            Console.WriteLine("jedną, która zawiera wszystkie książki, których numer porządkowy jest większy od 3 i mniejszy od 6");

            var kolekcja1 = kolekcjaKsiazek.Where(x => x.Id > 3 && x.Id < 6);
            foreach (Ksiazka k in kolekcja1)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("drugą, która zawiera wszystkie książki, których nazwiska kończą się na 'ski'");
            var kolekcja2 = kolekcjaKsiazek.Where(x => x.autor.Contains("ski"));
            foreach (Ksiazka k in kolekcja2)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("połącz te dwie kolecję w jedną usuwając przy tym powtarzające się elementy");
            var czescWspolna =

            Console.ReadKey();
        }
    }
}
