using System;
using TicketLibrary;

namespace OresundBron
{
    /// <summary>MC ticket</summary>
    public class MC: Vehicle
    {
        /// <summary>Price of a MC ticket</summary>
        private const double DefaultPrice = 210;

        /// <summary>Price of a MC ticket with Brobizz</summary>
        private const double DefaultPriceBrobizz = 73;

        /// <summary>Get price for a MC with or without Brobizz discount</summary>
        /// <param name="isBrobizz">Is Brobizz used (optional, default = false)</param>
        /// <returns>Price</returns>
        public double Price(bool isBrobizz = false)
        {
            return isBrobizz ? DefaultPriceBrobizz : DefaultPrice;
        }

        /// <summary>Get type of the vehicle</summary>
        /// <returns>Type</returns>
        public string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
