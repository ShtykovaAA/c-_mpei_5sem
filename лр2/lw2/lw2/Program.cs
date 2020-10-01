using System;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks.Sources;

namespace lw2
{
    class Program
    {
        static void CountOfRows(double q, double[,] matr, out int res)
        {
            res = 0;
            for (int i = 0; i < matr.GetUpperBound(0) + 1; i++)
            {
                double pr = 1;
                for (int j = 0; j < matr.GetUpperBound(1)+ 1; j++)
                {
                    pr *= matr[i, j];
                }
                if (pr > q)
                {
                    res++;
                }
            }
        }
        static void InputMatrix(out double[,] matr)
        {
            Console.Write("count of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("count of columns: ");
            int m = Convert.ToInt32(Console.ReadLine());
            matr = new double[n,m];

            for (int i = 0; i < matr.GetUpperBound(0) + 1; i++)
            {
                for(int j = 0; j < matr.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(i + " " + j + " ");
                    matr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix A");
            double[,] A;
            InputMatrix(out A);

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Matrix B");
            double[,] B;
            InputMatrix(out B);

            int countA;
            CountOfRows(1, A, out countA);
            Console.WriteLine("Count for matrix A = " + countA);

            int countB;
            Console.Write("Input Q: ");
            double Q = Convert.ToDouble(Console.ReadLine());
            CountOfRows(Q, B, out countB);
            Console.WriteLine("Count for matrix B = " + countB);
        }
    }
}
