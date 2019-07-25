using System;
namespace ConsoleApplication1
{
    public class Vectors
    {
        public static IVector Sum(IVector x, IVector y)
        {
            
            IVector ans;
            if (x is ArrayVector)
            {
                ans = new ArrayVector(Math.Max(x.Length, y.Length));
            }
            else
            {
                if (x is LinkedListVector)
                {
                    ans = new LinkedListVector(Math.Max(x.Length, y.Length));
                }
                else
                {
                    Console.WriteLine("Операция неприменима к объектам данных типов\nPress Enter...");
                    Console.ReadLine();
                    throw new Exception();
                }
            }
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

        public static double Scalar(IVector x, IVector y)
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

        public static double GetNorm(IVector x)
        {
            return x.GetNorm();
        }
    }
}