using System;

namespace laba2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string choice;
            double a, b, c;

            Console.WriteLine("Эта программа определяет есть ли решение уравнения вида ах^2 + bx + c = 0 в вещественных числах\n");
            while(flag)
            {
                Console.WriteLine("Хотите продолжить(введите yes, чтобы продолжить, no, чтобы выйти)\n");

                choice = Console.ReadLine(); 
                switch (choice)
                {
                    case "yes":
                        Console.Write("Введите вещественные a, b, c\na:   ");
                        a = Convert.ToDouble(Console.ReadLine());
                        
                        Console.Write("\nb:   ");
                        b = Convert.ToDouble(Console.ReadLine());

                        Console.Write("\nc:   ");
                        c = Convert.ToDouble(Console.ReadLine());
                        
                        if (b * b - 4 * a * c > 0)
                        {
                            Console.Write($"Уравнение {a}x^2 + {b}x + c = 0, имеет два корня\n");
                        } 
                        else if (b * b - 4 * a * c == 0)
                        {
                            Console.Write($"Уравнение {a}x^2 + {b}x + c = 0, имеет один корня\n");
                        }
                        else
                        {
                            Console.Write($"Уравнение {a}x^2 + {b}x + c = 0, не имеет вещественных корней\n");
                        }
                        break;
                    case "no":
                        flag = false;
                        break;
                    default:
                        Console.Write("Введите yes или no\n");
                        break;
                }
            }
        }
    }
}
