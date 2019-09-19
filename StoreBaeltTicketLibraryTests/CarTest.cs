using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;

namespace StoreBaeltTicketLibraryTests
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void PriceOnWeekday()
        {
            Car c = new Car();

            double actualPrice = c.Price(new DateTime(2019, 09, 20));

            Assert.AreEqual(actualPrice, 240);
        }
        
        [TestMethod]
        public void PriceOnWeekend()
        {
            Car c = new Car();

            double actualPrice = c.Price(new DateTime(2019, 09, 21));

            Assert.AreEqual(actualPrice, 192);
        }
    }
}
