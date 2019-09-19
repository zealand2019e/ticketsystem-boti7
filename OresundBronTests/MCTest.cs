using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;

namespace OresundBronTests
{
    [TestClass]
    public class MCTest
    {
        [TestMethod]
        public void Price()
        {
            MC mc = new MC();

            double actualPrice = mc.Price();

            Assert.AreEqual(actualPrice, 210);
        }
        
        [TestMethod]
        public void PriceBrobizz()
        {
            MC mc = new MC();

            double actualPrice = mc.Price(true);

            Assert.AreEqual(actualPrice, 73);
        }
        
        [TestMethod]
        public void VehicleType()
        {
            MC mc = new MC();

            string actualType = mc.VehicleType();

            Assert.AreEqual(actualType, "Oresund MC");
        }
    }
}
