using System;

namespace _153501_Brykulskii
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, res;

            Console.WriteLine("Введите делимое:  ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите делитель:  ");
            b = Convert.ToInt32(Console.ReadLine());
            res = a / b;
            Console.WriteLine($"Частное от деления: {res}");
        }
    }
}
