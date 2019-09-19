using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLibrary;

namespace TicketLibraryTests
{
    [TestClass]
    public class MCTest
    {
        [TestMethod]
        public void Price()
        {
            MC mc = new MC();

            double actualPrice = mc.Price();

            Assert.AreEqual(actualPrice, 125);
        }
        
        [TestMethod]
        public void PriceBrobizz()
        {
            MC mc = new MC();

            double actualPrice = mc.Price(true);

            Assert.AreEqual(actualPrice, 118.75, 0.01);
        }
        
        [TestMethod]
        public void VehicleType()
        {
            MC mc = new MC();

            string actualType = mc.VehicleType();

            Assert.AreEqual(actualType, "MC");
        }
        
        [TestMethod]
        public void LicensePlate()
        {
            MC mc = new MC();

            mc.Licenseplate = "AB12345";

            Assert.AreEqual(mc.Licenseplate, "AB12345");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LicensePlateIncorrect()
        {
            MC mc = new MC();

            mc.Licenseplate = "AB123456";
        }
    }
}
