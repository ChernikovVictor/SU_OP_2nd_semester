using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("ЛР-05. Черников В.Е. гр. № 6113. \n" +
                          "Программа для работы с векторами и односвязными списками, реализующими несколько стандарнтых интерфейсов \n" +
                          "Введите колличество векторов в массиве: ");
            int n = Int32.Parse(Console.ReadLine());
            IVector[] arr = new IVector[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Создание {0}-го вектора:\n" +
                                  "Выберете: 1. Вектор    2. Список", i + 1);
                int type = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите размерность вектора: ");
                int size = Int32.Parse(Console.ReadLine());
                IVector x;
                if (type == 1)
                    x = new ArrayVector(size);
                else
                    x = new LinkedListVector(size);
                Console.WriteLine("Введите элементы вектора: ");
                try
                {
                    for (int j = 0; j < size; j++)
                        x[j] = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный формат записи\nPress Enter...");
                    Console.ReadLine();
                    return;
                }
                arr[i] = x;
            }

            // Menu
            try
            {
                int stop = 0;
                while (stop == 0)
                {
                    Console.Clear();
                    IVector minVector = arr[0], maxVector = arr[0];
                    for (int i = 0; i < n; i++)
                    {
                        if (arr[i].CompareTo(maxVector) > 0)
                            maxVector = arr[i];
                        if (arr[i].CompareTo(minVector) < 0)
                            minVector = arr[i];
                        Console.WriteLine(arr[i].ToString());
                    }
                    Console.Write("Самый маленький вектор: " + minVector.ToString() + "\n" + 
                                  "Самый большой вектор: " + maxVector.ToString() + "\n" + 
                                  "1. Cортировать по возрастанию модулей \n" +
                                  "2. Сортировать по кол-ву координат \n" +
                                  "3. Клонировать вектор \n" + 
                                  "0. Выход \n" +
                                  "Выберете действие: ");
                    string buf = Console.ReadLine();
                    switch (buf)
                    {
                        case "1":
                            Array.Sort(arr, new LinkedListVector.SortByNorm());
                            break;
                        case "2":
                            Array.Sort(arr);
                            break;
                        case "3":
                            Console.Write("Выберете номер массива: ");
                            int j = Int32.Parse(Console.ReadLine());
                            j--;
                            IVector clone = (IVector)arr[j].Clone();
                            for (int i = 0; i < clone.Length; i++)
                                clone[i] = 5;
                            Console.WriteLine("Заменили в клоне все элементы на значение: 5 \n" +
                                              clone.ToString() + "\n" +
                                              "Исходный вектор не изменился: \n" +
                                              arr[j].ToString() + "\n" +
                                              "Нажмите Enter...");
                            Console.ReadLine();
                            break;
                        case "0":
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
                Console.WriteLine("Ошибка исполнения\nPress Enter...");
                Console.ReadLine();
                return;
            }
        }
    }
}