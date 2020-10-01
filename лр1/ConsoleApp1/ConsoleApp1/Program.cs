using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void NewMassive(int[,] matr, int[] arr, ref int[] res)
        {
            for(int i = 0; i < matr.GetUpperBound(0) + 1; i++)
            {
                int pr = 1;
                for(int j = 0; j< matr.GetLowerBound(0) + 1; j++)
                {
                    pr *= matr[i, j];
                }
                if (pr < arr[i])
                {
                    res[i] = arr[i];
                }
                else
                {
                    res[i] = 0;
                }
            }
        }

        static void Prois(int[,] matr, out int res)
        {
            res = 1;
            foreach(int i in matr){
                res *= i;
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];
            int[,] a = new int[n, n];
            int[] c = new int[n];

            Console.WriteLine("Array X");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Matrix A");
            for (int i = 0; i < a.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < a.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(i + " " + j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            NewMassive(a, x, ref c);
            Console.WriteLine("Massive C");
            foreach(int i in c)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int res;
            Prois(a, out res);
            Console.WriteLine("prois = " + res);
        }
    }
}
