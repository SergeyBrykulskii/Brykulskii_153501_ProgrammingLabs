using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    class AbsDiscount : IPrice
    {
        private double Discount { get; set; }
        private double Price { get; set; }

        public AbsDiscount(double price, double discount)
        {
            Discount = discount;
            Price = price;
        }

        public double GetPrice()
        {
            return Price - (Price * Discount / 100);
        }
    }
}
