using System;
namespace ConsoleApplication1
{
    [Serializable]
    public class ArrayVector : IVector, IComparable, ICloneable
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
            string st = a.Length.ToString();
            for (int i = 0; i < a.Length; i++)
                st = st + ' ' + a[i];
            return st;
        }

        public override bool Equals(object obj)
        {
            IVector v = obj as IVector;
            if (v == null || v.Length != this.Length)
                return false;
            for (int i = 0; i < v.Length; i++)
            {
                if (Math.Abs(v[i] - this[i]) > 1e-5)
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public int CompareTo(object obj)
        {
            IVector v = obj as IVector;
            if (v == null)
            {
                Console.Write("Невозможно сравнить\nPress Enter...");
                Console.ReadLine();
                throw new Exception();
            }
            if (this.Length > v.Length)
                return 1;
            if (this.Length < v.Length)
                return -1;
            return 0;
        }

        public object Clone()
        {
            ArrayVector clone = new ArrayVector(this.Length);
            clone.a = (double[])a.Clone();
            return clone;
        }
    }
}