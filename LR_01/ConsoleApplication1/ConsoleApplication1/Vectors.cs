using System;
namespace ConsoleApplication1
{
    public class Vectors
    {
        public static ArrayVector Sum(ArrayVector x, ArrayVector y)
        {
            ArrayVector ans = new ArrayVector(Math.Max(x.Length, y.Length));
            try
            {
                for (int i = 0; i < ans.Length; i++)
                    ans[i] =  x[i] + y[i];
                return ans;
            }
            catch (Exception)
            {
                Console.WriteLine("вектора имеют разную длину\nPress Enter...");
                Console.ReadLine();
                throw;
            }
        }

        public static double Scalar(ArrayVector x, ArrayVector y)
        {
            double ans = 0;
            try
            {
                for (int i = 0; i < Math.Max(x.Length, y.Length); i++)
                    ans += x[i] * y[i];
                return ans;
            }
            catch (Exception)
            {
                Console.WriteLine("вектора имеют разную длину\nPress Enter...");
                Console.ReadLine();
                throw;
            }
        }

        public static double GetNorm(ArrayVector x)
        {
            return x.GetNorm();
        }
    }
}