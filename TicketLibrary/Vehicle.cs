using System;

namespace TicketLibrary
{
    /// <summary>Base class of all vehicles</summary>
    public abstract class Vehicle
    {
        private string _licenseplate;

        /// <summary>Gets or sets the license plate number</summary>
        public string Licenseplate {
            get { return _licenseplate; }
            set { 
                if (value.Length > 7) { throw new ArgumentOutOfRangeException(); }
                else { _licenseplate = value; }
            }
        }

        /// <summary>Gets or sets the date when the vehicle passes the bridge</summary>
        public DateTime Date;

        /// <summary>Apply Brobizz discount to the given price</summary>
        /// <returns>Price after discount</returns>
        public double PriceWithBrobizz(double price)
        {
            return price * 0.95;
        }
    }
}
