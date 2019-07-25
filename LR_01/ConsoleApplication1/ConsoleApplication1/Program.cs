using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("ЛР-04. Черников В.Е. гр. № 6113. \n" +
                          "Программа для работы с векторами и односвязными списками, реализующими один интерфейс \n" +
                          "Часть 1. Вектора \n" +
                          "Введите размерность вектора: ");
            int n;
            IVector arr;
            try
            {
                n = Int32.Parse(Console.ReadLine());
                arr = new ArrayVector(n);
                Console.WriteLine("Введите элементы вектора");
                for (int i = 0; i < n; i++)
                    arr[i] = Double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
                return;
            }
            catch (Exception) { return; }

            string buf = "1";
            try
            {
                while (buf != "3")
                {
                    Console.Clear();
                    Console.Write("Вектор: " + arr.ToString() + "\n" +
                                  "Модуль вектора: " + Vectors.GetNorm(arr) + "\n" +
                                  "Кол-во координат вектора: " + arr.Length + "\n" +
                                  "1. Прибавить к вектору другой вектор \n" +
                                  "2. Скалярно умножить вектор на другой вектор \n" +
                                  "3. Выход \n" +
                                  "Выберете действие: ");
                    buf = Console.ReadLine();
                    switch (buf)
                    {
                        case "1":
                            Console.Write("Введите размерность вектора: ");
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
                        case "2":
                            Console.Write("Введите размерность вектора: ");
                            ArrayVector v2 = new ArrayVector(Int32.Parse(Console.ReadLine()));
                            Console.WriteLine(arr.ToString() + "\n" +
                                              "x \n" +
                                              v2.ToString() + "\n" +
                                              "=");
                            Console.WriteLine(Vectors.Scalar(arr, v2) + "\n" +
                                              "Нажмите Enter...");
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.Clear();
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
                Console.WriteLine("Ошибка исполнения\nPress Enter...");
                Console.ReadLine();
                return;
            }

            // Работа со списками
            Console.Write("Часть 2. Списки \n" +
                          "Введите размерность списка: ");
            n = Int32.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Отрицательная размерность. Список по умолчанию: 5 элементов \n" +
                                  "Нажмите Enter...");
                Console.ReadLine();
                arr = new LinkedListVector();
            }
            else
            {
                arr = new LinkedListVector(n);
            }
            Console.WriteLine("Введите элементы списка");
            try
            {
                for (int i = 0; i < n; i++)
                    arr[i] = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
                return;
            }

            while (buf != "2")
            {
                Console.Clear();
                Console.WriteLine("Список: " + arr.ToString() + "\n" +
                                  "Модуль вектора: " + Vectors.GetNorm(arr) + "\n" +
                                  "Число координат: " + arr.Length + "\n" +
                                  "1. Изменить значение элемента списка \n" +
                                  "2. Выход \n" +
                                  "Введите номер: ");
                buf = Console.ReadLine();
                switch (buf)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("Введите индекс");
                            int i = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Введите новое значение");
                            double x = double.Parse(Console.ReadLine());
                            i--;
                            arr[i] = x;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e);
                            Console.WriteLine("Press Enter...");
                            Console.ReadLine();
                            return;
                        }
                        catch (Exception) { return; }
                        break;

                    case "2":
                        break;
                    default:
                        Console.WriteLine("Неверный номер\nPress Enter...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}