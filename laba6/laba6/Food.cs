using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace laba6
{
    abstract class Food : Products
    {
        public Food(string name, int price, int weight) : base(name, price, weight)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Название: {0}", Name);
            Console.WriteLine("Цена: {0}", Price);
            Console.WriteLine("Вес: {0}", Weight);
        }
        
        
    }
}
