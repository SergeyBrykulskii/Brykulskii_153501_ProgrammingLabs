using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public class Rate
    {
        private int price;

        public Rate(int price)
        {
            this.price = price;
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
