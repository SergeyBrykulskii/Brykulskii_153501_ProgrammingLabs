using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace laba6
{
    public sealed class Food : Products
    {
        public double Weight { get; set; }
        public DateTime Date { get; set; }
        public Food(string name, int price, double weight, int year, int month, int day) : base(name, price) 
        {
            Weight = weight;
            Date = new DateTime(year, month, day);
        }
        public override bool IsGood()
        {
            
            if (Date > DateTime.Today)
            {
                Console.WriteLine("Продукт свежий");
                return true;
            }
            else
            {
                Console.WriteLine("Продукт просрочен");
                return false;
            }
        }
        public override void Print()
        {
            Console.WriteLine("Название: {0}", Name);
            Console.WriteLine("Цена: {0}", Price);
            Console.WriteLine("Вес: {0}", Weight);
        }
    }
}
