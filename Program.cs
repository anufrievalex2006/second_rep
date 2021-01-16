using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {
        static void fillMatr(int[,] m)
        {
            Random r = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = r.Next(10, 100);
                }
            }
        }
        static void Main(string[] args)
        {
            int m = 3, n = 3;
            int[,] matr = new int[m, n], matr1 = new int[m, n], res = new int[m, n];
            fillMatr(matr);
            fillMatr(matr1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matr[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n*\n\n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matr1[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n||\n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int j1 = 0; j1 < n; j1++)
                        res[i, j] += matr[i, j1] * matr1[j1, j];
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(res[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
