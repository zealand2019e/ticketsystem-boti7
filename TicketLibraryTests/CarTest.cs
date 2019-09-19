using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLibrary;

namespace TicketLibraryTests
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Price()
        {
            Car c = new Car();

            double actualPrice = c.Price();

            Assert.AreEqual(actualPrice, 240);
        }
        
        [TestMethod]
        public void PriceBrobizz()
        {
            Car c = new Car();

            double actualPrice = c.Price(true);

            Assert.AreEqual(actualPrice, 228);
        }
        
        [TestMethod]
        public void VehicleType()
        {
            Car c = new Car();

            string actualType = c.VehicleType();

            Assert.AreEqual(actualType, "Car");
        }
        
        [TestMethod]
        public void LicensePlate()
        {
            Car c = new Car();

            c.Licenseplate = "AB12345";

            Assert.AreEqual(c.Licenseplate, "AB12345");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LicensePlateIncorrect()
        {
            Car c = new Car();

            c.Licenseplate = "AB123456";
        }
    }
}
