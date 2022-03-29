using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_2
{
    public class Services
    {
        public static double ChooseX(double a, double b, double z)
        {
            double x;
            if (z < a * b)
            {
                x = Math.Sqrt(a * a + b * b * z);
                Console.WriteLine("First branch");
            }
            else
            {
                x = Math.Pow(Math.Sin(z), 2) + Math.Abs(a * b * z);
                Console.WriteLine("Second branch");
            }
            return x;
        }
        public static double SolveEquation(double a, double b, double z)
        {
            double x = ChooseX(a, b, z);
            return (a * x + b * x * Math.Cos(Math.Sqrt(x))) / (x + a * b);
        }
    }
}
