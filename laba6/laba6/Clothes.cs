using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    public class Clothes : Products
    {
        public int Size { get; set; }
        public Clothes(string name, int price, int size) : base(name, price)
        {
            Size = size;
        }
        public override bool IsGood()
        {
            if (Size < 40 && Size > 20)
            {
                Console.WriteLine("Товар надежный");
                return true;
            }
            else
            {
                Console.WriteLine("Товар не надежный");
                return false;
            }
        }
    }
}
