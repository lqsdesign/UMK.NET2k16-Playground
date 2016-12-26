using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dzielenie;

namespace TestyDzielenie
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double dzielna = 1;
            double dzielnik = 2;
            Assert.AreEqual(dzielna / dzielnik, Dzielenie.Dzielenie.Podziel(dzielna, dzielnik));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Random rng = new Random();
            double dzielna = 0;
            double dzielnik = 0;

            for (int i = 0; i < 100; i++)
            {
                dzielna = rng.Next(100);
                dzielnik = rng.Next(100);

                if (dzielna != 0 && dzielnik != 0)
                {
                    Assert.AreEqual(dzielna / dzielnik, Dzielenie.Dzielenie.Podziel(dzielna, dzielnik));
                }
                else
                {
                    i--;
                }

            }
            
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod3()
        {
            double dzielna = 1;
            double dzielnik = 0;
            Dzielenie.Dzielenie.Podziel(dzielna, dzielnik);
        
        }
    }
}
