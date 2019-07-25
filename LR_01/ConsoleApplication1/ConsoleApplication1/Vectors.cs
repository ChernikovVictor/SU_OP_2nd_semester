using System;

namespace ConsoleApplication1
{
    public class Vectors
    {
        public static ArrayVector Sum(ArrayVector x, ArrayVector y)
        {
            ArrayVector ans = new ArrayVector(Math.Max(x.GetLength(), y.GetLength()));
            try
            {
                for (int i = 0; i < ans.GetLength(); i++)
                    ans.SetElement(i, x.GetElement(i) + y.GetElement(i));
                return ans;
            }
            catch (Exception)
            {
                Console.WriteLine("вектора имеют разную длину");
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
                throw;
            }
        }

        public static double Scalar(ArrayVector x, ArrayVector y)
        {
            double ans = 0;
            try
            {
                for (int i = 0; i < Math.Max(x.GetLength(), y.GetLength()); i++)
                    ans += x.GetElement(i) * y.GetElement(i);
                return ans;
            }
            catch (Exception)
            {
                Console.WriteLine("вектора имеют разную длину");
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
                throw;
            }
        }

        public static ArrayVector NumberMul(ArrayVector arr, int x)
        {
            ArrayVector ans = new ArrayVector(arr.GetLength());
            for (int i = 0; i < ans.GetLength(); i++)
                ans.SetElement(i, arr.GetElement(i) * x);
            return ans;
        }

        public static double GetNorm(ArrayVector x)
        {
            return x.GetNorm();
        }
    }
}