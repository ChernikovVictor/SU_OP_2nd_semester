using System;

namespace ConsoleApplication1
{
    public class ArrayVector
    {
        private int[] a;

        public ArrayVector()
        {
            Random gen = new Random();
            a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                a[i] = gen.Next(-100, 100);
            }
        }

        public ArrayVector(int n)
        {
            Random gen = new Random();
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = gen.Next(-100, 100);
            }
        }

        public int GetLength()
        {
            return a.Length;
        }

        public void SetElement(int i, int x)
        {
            try
            {
                a[i] = x;
            }
            catch (Exception)
            {
                Console.WriteLine("Неверный индекс");
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
            }
        }

        public int GetElement(int i)
        {
            try
            {
                return a[i];
            }
            catch (Exception)
            {
                Console.WriteLine("Неверный индекс");
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
                throw;
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

        public string SumPositivesFromChetIndex()
        {
            int res = 0;
            for (int i = 0; i < a.Length; i += 2)
            {
                res += (a[i] > 0) ? a[i] : 0;
            }
            if (res == 0)
                return "В массиве нет искомых элементов";
            else
            {
                return res.ToString();
            }
        }

        // среднее значение всех модулей элементов массива
        private double Average()
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += Math.Abs(a[i]);
            }
            return sum / a.Length;
        }

        public string SumLessFromNechetIndex()
        {
            int res = 0, test = 0;
            double average = Average();
            for (int i = 1; i < a.Length; i += 2)
            {
                res += (a[i] < average) ? a[i] : 0;
                if (a[i] < average)
                    test = 1;
            }
            if (test == 1)
                return res.ToString();
            else
            {
                return "В массиве нет искомых элементов";
            }
        }

        public string MulChet()
        {
            int p = 1, test = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] > 0 && a[i] % 2 == 0)
                {
                    p *= a[i];
                    test = 1;
                }
            if (test == 1)
                return p.ToString();
            else
                return "В массиве нет искомых элементов";
        }

        public string MulNechet()
        {
            int p = 1, test = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] % 3 != 0 && a[i] % 2 != 0)
                {
                    p *= a[i];
                    test = 1;
                }
            if (test == 1)
                return p.ToString();
            else
                return "В массиве нет искомых элементов";
        }
        
        private void Swap(int i, int j)
        {
            int swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }

        private void QSort(int left, int right)
        {
            int i = left, j = right;
            int middle = a[(i + j) / 2];
            do
            {
                while (a[i] < middle)
                    i++;
                while (a[j] > middle)
                    j--;
                if (i <= j)
                {
                    Swap(i, j);
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j)
                this.QSort(left, j);
            if (i < right)
                this.QSort(i, right);
        }

        public void SortUp()
        {
            QSort(0, a.Length - 1);
        }

        public void SortDown()
        {
            QSort(0, a.Length - 1);
            Array.Reverse(a);
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