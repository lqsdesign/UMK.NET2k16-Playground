using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ksiegarnia1;

namespace TestKsiazka
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestKonstruktora()
        {
            Edukacyjne ksiazka = new Edukacyjne("T", "A", 1, 1, "P");
            Assert.AreEqual("T", ksiazka.Tytul);
            Assert.AreEqual("A", ksiazka.Autor);
            Assert.AreEqual((uint)1, ksiazka.Ilosc);
            Assert.AreEqual(1, ksiazka.klasa);
            Assert.AreEqual("P", ksiazka.przedmiot);
        }

        [TestMethod]
        public void TestSprzedajKsiazke()
        {
            Edukacyjne ksiazka = new Edukacyjne("T", "A", 1, 1, "P");

            ksiazka.SprzedajKsiazke();
            Assert.AreEqual((uint)0, ksiazka.Ilosc);

            ksiazka.SprzedajKsiazke();
            Assert.AreEqual((uint)0, ksiazka.Ilosc);
        }
    }
}
