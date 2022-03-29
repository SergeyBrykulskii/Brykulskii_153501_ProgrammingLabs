using Laba3_2;

double a, b, z;

Console.Write("Enter equation coefficients from 2 variant(a, b, z)\n a = ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write(" b = ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write(" z = ");
z = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Solution of the equation: {Services.SolveEquation(a, b, z)}");