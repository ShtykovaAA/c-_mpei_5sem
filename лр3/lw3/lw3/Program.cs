using System;


/*26.Если хотя бы один максимальный элемент   A лежит на главной диагонали, 
 * присвоить начальным элементам  нового массива C значения элементов, 
 * лежащих выше главной диагонали, а остальным элементам   значения прочих элементов  .*/
namespace lw3
{
    class matrix
    {
        public double[,] matr;
        public bool flag = false;

        public matrix(int k)
        {
            matr = new double[k, k];
        }
       
        public void input()
        {
            for (int i =0; i < matr.GetUpperBound(0)+1; i++)
            {
                for (int j =0; j < matr.GetUpperBound(1)+ 1; j++)
                {
                    Console.Write(i + " " + j + " ");
                    matr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }
        public void output()
        {
            Console.WriteLine("Output Matrix");
            for (int i = 0; i < matr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matr.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(i + " " + j + " ");
                    Console.WriteLine(matr[i, j]);
                }
            }
        }
        

        double MaxELem()
        {
            double maxi = matr[0, 0];
            foreach (double x in matr)
            {
                if (x >= maxi)
                {
                    maxi = x;
                }
            }
            return maxi;
        }

        private void CheckDiagonal()
        {
            double maxi = MaxELem();
            for (int i = 0; i < matr.GetUpperBound(0) + 1; i++)
            {
                if (matr[i,i] == maxi)
                {
                    flag = true;
                    break;
                }
            }
        }
        public bool IsOnMainDiagonal
        {
            
            get
            {
                CheckDiagonal();
                return flag;
            }
        }
    }

    class Task : matrix {
        public double[] c;
        
        public Task(int k) : base(k) {
            c = new double[k * k];
        }

        public void CreateMas()
        {
            int kol = 0;
            for (int i = 0; i < matr.GetUpperBound(0) + 1; i++)
            {
                for (int j = i; j < matr.GetUpperBound(1)+ 1; j++)
                { 
                    c[kol] = matr[i, j];
                    kol++;

                }
            }

            int kol2 = 0;
            for (int i = 1; i < matr.GetUpperBound(0) + 1; i++)
            { 
                for (int j = 0; j < i; j++)
                {
                    c[kol + kol2] = matr[i, j];
                    kol2++;
                }

            }
        }
        
        public double[] MasC
        {
            get {
            return c;
            }
        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {

            int k = 3;
            Task t;
            t = new Task(k);
            t.input();
            if (t.IsOnMainDiagonal)
            {
                t.CreateMas();
                double[] c = t.MasC;
                Console.WriteLine("New massive C: ");
                foreach (double x in c)
                {
                    Console.WriteLine(x);
                }
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
