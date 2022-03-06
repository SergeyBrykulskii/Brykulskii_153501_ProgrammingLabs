using System;

namespace laba2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Введите координаты точки (x, y)\n x =   ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n y =   ");
            y = Convert.ToInt32(Console.ReadLine());

           // x = Math.Abs(x);

            if (Math.Abs(y) < Math.Sqrt(100 - x * x) && y < Math.Abs(x))
            {
                Console.WriteLine("Точка находится внутри заданной области");
            } 
            else if (Math.Abs(y) <= Math.Sqrt(100 - x * x) && y <= Math.Abs(x))
            {
                Console.WriteLine("Точка находится на границе заданной области");
            }
            else
                Console.WriteLine("Точка находится вне заданной области");
        }
    }
}
