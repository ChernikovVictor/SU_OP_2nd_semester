using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("ЛР-01. Черников В.Е. гр. № 6113. \n" +
                              "Программа для создания и обработки вектора чисел \n" +
                              "Введите размер вектора: ");
            int n = Int32.Parse(Console.ReadLine());
            ArrayVector arr = new ArrayVector(n);
            Console.WriteLine("Введите элементы вектора");
            for (int i = 0; i < n; i++)
                arr.SetElement(i, Int32.Parse(Console.ReadLine()));
            try
            {
                int stop = 0;
                while (stop == 0)
                {
                    Console.Clear();
                    Console.Write("Вектор: " + arr.ToString() + "\n" +
                                  "Модуль вектора: " + Vectors.GetNorm(arr) + "\n" +
                                  "SumPositivesFromChetIndex: " + arr.SumPositivesFromChetIndex() + "\n" +
                                  "SumLessFromNechetIndex: " + arr.SumLessFromNechetIndex() + "\n" +
                                  "MulChet: " + arr.MulChet() + "\n" +
                                  "MulNechet: " + arr.MulNechet() + "\n" +
                                  "1. Сортировать вектор по возрастанию \n" +
                                  "2. Сортировать вектор по убыванию \n" +
                                  "3. Прибавить к вектору другой вектор \n" +
                                  "4. Скалярно умножить вектор на другой вектор \n" +
                                  "5. Умножить вектор на число \n" +
                                  "6. Выход \n" +
                                  "Выберете действие: ");
                    string buf = Console.ReadLine();
                    switch (buf) 
                    {
                        case "1": 
                            arr.SortUp();
                            break;
                        case "2": 
                            arr.SortDown();
                            break;
                        case "3":
                            Console.Write("Введите размер вектора: ");
                            ArrayVector v1 = new ArrayVector(Int32.Parse(Console.ReadLine()));
                            Console.WriteLine(arr.ToString() + "\n" +
                                              "+ \n" +
                                              v1.ToString() + "\n" +
                                              "=");
                            arr = Vectors.Sum(arr, v1);
                            Console.WriteLine(arr.ToString() + "\n" +
                                              "Нажмите Enter...");
                            Console.ReadLine();
                            break;
                        case "4":
                            Console.Write("Введите размер вектора: ");
                            ArrayVector v2 = new ArrayVector(Int32.Parse(Console.ReadLine()));
                            Console.WriteLine(arr.ToString() + "\n" +
                                              "x \n" +
                                              v2.ToString() + "\n" +
                                              "=");
                            Console.WriteLine(Vectors.Scalar(arr, v2) + "\n" +
                                              "Нажмите Enter...");
                            Console.ReadLine();
                            break;
                        case "5":
                            Console.Write("Введите число: ");
                            int x = Int32.Parse(Console.ReadLine());
                            arr = Vectors.NumberMul(arr, x);
                            break;
                        case "6":
                            stop = 1;
                            break;
                        default:
                            Console.WriteLine("Неправильный символ \n" +
                                              "Нажмите Enter...");
                            Console.ReadLine();
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка исполнения");
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
            }
            
        }
    }
}