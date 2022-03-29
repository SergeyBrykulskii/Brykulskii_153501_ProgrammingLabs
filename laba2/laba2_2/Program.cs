using System;

namespace laba2_2
{
    public class Program
    {
        public static short IsInZone(int x, int y)
        {
            if (Math.Abs(y) < Math.Sqrt(100 - x * x) && y < Math.Abs(x))
            {
                Console.WriteLine("Точка находится внутри заданной области");
                return 1;
            }
            else if (Math.Abs(y) <= Math.Sqrt(100 - x * x) && y <= Math.Abs(x))
            {
                Console.WriteLine("Точка находится на границе заданной области");
                return -1;
            }
            else
            {
                Console.WriteLine("Точка находится вне заданной области");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Введите координаты точки (x, y)\n x =   ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n y =   ");
            y = Convert.ToInt32(Console.ReadLine());

            // x = Math.Abs(x);

            IsInZone(x, y);
        }
    }
}
