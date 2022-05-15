using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    class NoDiscount : IPrice
    {
        private double Price { get; set; }

        public NoDiscount(double price)
        {
            Price = price;
        }
        public double GetPrice()
        {
            return Price;
        }
    }
}
