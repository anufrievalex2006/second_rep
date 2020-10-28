using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CA1
{
    class Program
    {
        static double pow(double x, double y)
        {
            return Math.Pow(x, y);
        }
        static double sin(double a)
        {
            return Math.Sin(a);
        }
        static double cos(double a)
        {
            return Math.Cos(a);
        }
        static double tan(double a)
        {
            return Math.Tan(a);
        }
        static double cot(double a)
        {
            return 1 / Math.Tan(a);
        }
        static double sec(double a)
        {
            return 1 / Math.Cos(a);
        }
        static double csc(double a)
        {
            return 1 / Math.Sin(a);
        }
        static double rnd(double a)
        {
            return Math.Round(a);
        }
        static double rndf(double a, int b)
        {
            return Math.Round(a, b);
        }
        static double sqrt(double a)
        {
            return Math.Sqrt(a);
        }
        static double grad(double a)
        {
            return a * (180 / Math.PI);
        }
        static double rad(double a)
        {
            return a * (Math.PI / 180);
        }
        static double abs(double a)
        {
            return Math.Abs(a);
        }
        static readonly double pi = Math.PI;
        static void Main(string[] args)
        {
            Console.WriteLine(pow(sin(3), 2) + pow(cos(3), 2));
            Console.Read();
        }
    }
}
