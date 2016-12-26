using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AsystentZakupow.Model;
namespace TestyJednostkoweSumatora
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMetodyDodajKwote()
        {
            //arrange
            Sumator sumator = new Sumator(50, 200);

            //act
            sumator.DodajKwote(75);

            //assert
            Assert.AreEqual(50 + 75, sumator.Suma);
        }


        private Random rng = new Random();
        [TestMethod]
        public void TestMetodyDodajKwoteRandom()
        {
            for (int i = 0; i < 100; i++)
            {

                //arrange
                Sumator sumator = new Sumator(50, 200);

                //act
                sumator.DodajKwote(rng.Next(20));

                //assert
                Assert.AreEqual(50 + 75, sumator.Suma);
            }
        }

        [TestMethod]
        public void TestKonstruktora()
        {
            Sumator sumator = new Sumator(500, 100);
            Assert.AreEqual(500, sumator.Suma);
        }

        [TestMethod]
        public void PrawdziwyTestKontruktora()
        {
            Sumator sumator = new Sumator(50, 100);
            PrivateObject po = new PrivateObject(sumator);

            Assert.AreEqual(50M, po.GetField("suma"));
            Assert.AreEqual(100M, po.GetField("limit"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestKonstruktora2()
        {
            Sumator sumator = new Sumator(500, 100);
        }
    }
}
