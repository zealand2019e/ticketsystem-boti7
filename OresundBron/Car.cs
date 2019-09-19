using System;
using TicketLibrary;

namespace OresundBron
{
    /// <summary>Car ticket</summary>
    public class Car: Vehicle
    {
        /// <summary>Price of a car ticket</summary>
        private const double DefaultPrice = 410;

        /// <summary>Price of a car ticket with Brobizz</summary>
        private const double DefaultPriceBrobizz = 161;

        /// <summary>Get price for a car with or without Brobizz discount</summary>
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
            return "Oresund car";
        }
    }
}
