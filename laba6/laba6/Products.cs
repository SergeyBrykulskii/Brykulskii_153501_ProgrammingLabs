using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    public abstract class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Products(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public abstract bool IsGood();
        public virtual void Print()
        {
            Console.WriteLine("Товар: {0}", Name);
            Console.WriteLine("Цена: {0}", Price);
        }
    }
}
