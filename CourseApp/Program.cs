using System;

namespace lab1matfunc
{
    public class Program
    {
        public static double MyFunction(double a, double b, double x)
        {
            var y = (Math.Pow(a, x) - Math.Pow(b, x)) * Math.Pow(a * b, 1.0 / 3) / Math.Log10(a / b);
            return y;
        }

        public static double[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            int i = 0;
            double k = Math.Round((xk - xn) / dx);
            var y = new double[(int)k];
            for (double x = xn; x < xk; x += dx)
            {
                y[i] = MyFunction(a, b, x);
                i++;
            }

            return y;
        }

        public static double[] TaskB(double a, double b, double[] x)
        {
            var y = new double[x.Length];
            for (var i = 0; i < x.Length; i++)
            {
                y[i] = MyFunction(a, b, x[i]);
            }

            return y;
        }

        public static void Main(string[] args)
        {
            const double xn = 3.2;
            Console.WriteLine(xn);
            Console.WriteLine(xn);
            const double xk = 6.2;
            const double dk = 0.6;
            const double a = 0.4;
            const double b = 0.8;
            Console.WriteLine("Задание А:");
            foreach (var item in TaskA(b, xn, xk, dx))
            {
                Console.WriteLine($"y = {item}");
            }
            var x = new double[] { 4.48, 3.56, 2.78, 5.28, 3.21 };
            var taskBRes = TaskB(b, x);
            Console.WriteLine("Задание B:");
            foreach (var item in taskBRes)
            {
                Console.WriteLine($"y = {item}");
            }
            Console.ReadLine();
        }
    }
}