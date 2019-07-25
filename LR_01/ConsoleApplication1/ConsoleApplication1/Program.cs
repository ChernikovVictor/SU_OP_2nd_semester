using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("ЛР-02. Черников В.Е. гр. № 6113. \n" +
                          "Программа для работы с векторами и односвязными списками списками \n" +
                          "Часть 1. Вектора \n" +
                          "Введите размер вектора: ");
            int n;
            ArrayVector arr;
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
                        case "2":
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

            // task 2
            Console.Write("Часть 2. Списки \n" +
                          "Введите размер списка: ");
            n = Int32.Parse(Console.ReadLine());
            LinkedListVector list;
            if (n < 0)
            {
                Console.WriteLine("Отрицательный размер. Список по умолчанию: 5 элементов \n" +
                                  "Нажмите Enter...");
                Console.ReadLine();
                list = new LinkedListVector();
            }
            else
            {
                list = new LinkedListVector(n);
            }

            Console.WriteLine("Введите элементы списка");
            try
            {
                for (int i = 0; i < n; i++)
                    list[i] = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
                return;
            }

            buf = "1";
            while (buf != "2")
            {
                Console.Clear();
                Console.WriteLine("Список: " + list.ToString() + "\n" +
                                  "Модуль вектора: " + list.GetNorm() + "\n" +
                                  "Число координат: " + list.Length + "\n" +
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
                            list[i] = x;
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