using System;
namespace ConsoleApplication1
{
    public class ArrayVector
    {
        private double[] a;

        public ArrayVector()
        {
            Random gen = new Random();
            a = new double[5];
            for (int i = 0; i < 5; i++)
            {
                a[i] = gen.NextDouble();
            }
        }

        public ArrayVector(int n)
        {
            Random gen = new Random();
            try
            {
                a = new double[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = gen.NextDouble();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Неверный размер вектора\nPress Enter...");
                Console.ReadLine();
                throw;
            }
        }

        public int Length
        {
            get { return a.Length; }
        }

        public double this[int i]
        {
            get
            {
                try
                {
                    return a[i];
                }
                catch (Exception)
                {
                    Console.WriteLine("Выход за границы вектора\nPress Enter...");
                    Console.ReadLine();
                    throw;
                }
            }
            set
            {
                try
                {
                    a[i] = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Выход за границы вектора\nPress Enter...");
                    Console.ReadLine();
                    throw;
                }
            }
        }

        public double GetNorm()
        {
            double res = 0;
            foreach (double x in a)
            {
                res += x * x;
            }
            return Math.Sqrt(res);
        }
        
        public override string ToString()
        {
            string st = "";
            for (int i = 0; i < a.Length; i++)
                st = st + ' ' + a[i].ToString();
            return st;
        }
    }
}