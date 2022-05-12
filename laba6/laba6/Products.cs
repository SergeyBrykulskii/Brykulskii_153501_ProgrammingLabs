using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    abstract class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public abstract double Weight { get; set; }
        public Products(string name, int price, int weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
        public abstract void Show();

        public virtual void Print()
        {
            Console.WriteLine("Продукт: " + this.Name);
            Console.WriteLine("Цена: " + Price);
        }
    }
}
