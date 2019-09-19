using System;
using TicketLibrary;

namespace StoreBaeltTicketLibrary
{
    public class Car: TicketLibrary.Car
    {
        /// <summary>Get price for a car with 20% discount on weekends and with or without Brobizz</summary>
        /// <param name="isBrobizz">Is Brobizz used (optional, default = false)</param>
        /// <returns>Price</returns>
        public double Price(DateTime date, bool isBrobizz = false)
        {
            double price = base.Price();
            DayOfWeek today = date.DayOfWeek;

            if (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
            {
                price *= 0.80;
            }

            return isBrobizz ? PriceWithBrobizz(price) : price;
        }
    }
}
