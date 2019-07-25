using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
                    ans[i] = x[i] + y[i];
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

        // записать вектор в конец в байтовый поток 
        public static void OutputVector(IVector v, string fileName)
        {
            FileStream fOut = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            fOut.WriteByte((byte)v.Length);
            for (int i = 0; i < v.Length; i++)
            {
                fOut.WriteByte((byte)v[i]);
            }
            fOut.Close();
        }

        // считать все вектора из байтового потока и вывести на экран
        public static void InputVector(string fileName)
        {
            try
            {
                FileStream fIn = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                int n = fIn.ReadByte();
                while (n != -1) // n == -1 => конец потока
                {
                    IVector v = new ArrayVector(n);
                    for (int i = 0; i < n; i++)
                    {
                        v[i] = fIn.ReadByte();
                    }
                    Console.WriteLine(v.ToString());
                    n = fIn.ReadByte();
                }
                fIn.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл с указанным именем не существует");
            }
            catch (Exception)
            {
                Console.WriteLine("Файл пустой или содержит некорректные данные");
            }
        }

        // записать вектор в текстовый файл
        public static void WriteVector(IVector v, string fileName)
        {
            StreamWriter f = new StreamWriter(fileName, true); // true => запись в конец файла
            f.WriteLine(v.ToString());
            f.Close();
        }

        // считать все вектора из текстового файла и вывести на экран
        public static void ReadVector(string fileName)
        {
            try
            {
                StreamReader f = new StreamReader(fileName);
                Console.WriteLine(f.ReadToEnd());
                f.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл с таким именем не существует");
            }
        }

        // сериализовать массив векторов
        public static void SerializeVector(IVector[] v, string fileName)
        {
            FileStream f = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f, v);
            f.Close();
        }

        // десериализовать массив векторов и вывести на экран
        public static void DeserializeVector(string fileName)
        {
            try
            {
                FileStream f = new FileStream(fileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                IVector[] arr = (IVector[])bf.Deserialize(f);
                foreach (IVector x in arr)
                {
                    Console.WriteLine(x.ToString());
                }
                f.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл с указанным именем не существует");
            }
            catch (Exception)
            {
                Console.WriteLine("Файл пустой или содержит некорректные данные");
            }
        }
    }
}