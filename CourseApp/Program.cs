using System;

namespace lab1matfunc
{
class Program
{
static double Func(double a, double b, double x)
{
double y = (Math.Pow(a, x) - Math.Pow(b, x)) * Math.Pow(a * b, 1.0 / 3) / Math.Log10(a / b);
return y;
}
static void Main(string[] args)
{
double a = 0.4;
double b = 0.8;
double y;
for (double x = 3.2; x < 6.3; x = x + 0.6)
{
Console.WriteLine(Func(a, b, x));
}
for (int i = 0; i < 5; i++)
{
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Func(a, b, x));
}
}
}
}
