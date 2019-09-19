using System;

namespace TicketLibrary
{
    /// <summary>MC ticket</summary>
    public class MC: Vehicle
    {
        /// <summary>Price of a MC ticket</summary>
        private const double DefaultPrice = 125;

        /// <summary>Get price for a car with or without Brobizz discount</summary>
        /// <param name="isBrobizz">Is Brobizz used (optional, default = false)</param>
        /// <returns>Price</returns>
        public double Price(bool isBrobizz = false)
        {
            return isBrobizz ? PriceWithBrobizz(DefaultPrice) : DefaultPrice;
        }

        /// <summary>Get type of the vehicle</summary>
        /// <returns>Type</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
