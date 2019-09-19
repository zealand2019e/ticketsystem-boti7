using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;

namespace OresundBronTests
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Price()
        {
            Car c = new Car();

            double actualPrice = c.Price();

            Assert.AreEqual(actualPrice, 410);
        }
        
        [TestMethod]
        public void PriceBrobizz()
        {
            Car c = new Car();

            double actualPrice = c.Price(true);

            Assert.AreEqual(actualPrice, 161);
        }

        [TestMethod]
        public void VehicleType()
        {
            Car c = new Car();

            string actualType = c.VehicleType();

            Assert.AreEqual(actualType, "Oresund car");
        }
    }
}
