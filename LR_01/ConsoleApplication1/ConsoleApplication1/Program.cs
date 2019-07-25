using System;
using System.IO;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("ЛР-06. Черников В.Е. гр. № 6113. \n" +
                          "Программа для работы с байтовыми и текстовыми потоками\n" +
                          "Введите колличество векторов в массиве: ");
            int n = Int32.Parse(Console.ReadLine());
            IVector[] arr = new IVector[n];
            for (int i = 0; i < n; i++)
            {
                try
                {
                    Console.WriteLine("Создание {0}-го вектора:\n" +
                                      "Выберете: 1. Вектор    2. Список", i + 1);
                    int type = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите размерность вектора: ");
                    int size = Int32.Parse(Console.ReadLine());
                    IVector x;
                    if (type == 1)
                        x = new ArrayVector(size);
                    else if (type == 2)
                        x = new LinkedListVector(size);
                    else 
                        throw new Exception();
                    Console.WriteLine("Введите элементы вектора: ");
                    try
                    {
                        for (int j = 0; j < size; j++)
                            x[j] = Double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Неверный формат записи");
                        throw;
                    }
                    arr[i] = x;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка\nНажмите Enter...");
                    Console.ReadLine();
                    return;
                }
            }
            
            string buff = "1";
            while (buff != "0")
            {
                Console.Clear();
                foreach (IVector x in arr)
                {
                    Console.WriteLine(x.ToString());
                }
                Console.WriteLine("1. Записать массив в файл байтов \n" +
                                  "2. Получить массив из файла байтов \n" +
                                  "3. Записать массив в текстовый файл \n" +
                                  "4. Получить массив из текстового файла \n" +
                                  "5. Записать массив в файл как объект (сериализовать) \n" +
                                  "6. Получить массив из файла (десериализовать) \n" +
                                  "0. Выход \n" +
                                  "Доступные файлы: test1.bin, test2.bin, test1.txt, test2.txt, test1.v, test2.v\n" +
                                  "Введите номер: ");
                buff = Console.ReadLine();
                switch (buff)
                {
                    case "1":
                        Console.WriteLine("Введите имя файла: ");
                        string fileName = Console.ReadLine();
                        foreach (IVector x in arr)
                        {
                            Vectors.OutputVector(x, fileName);
                        }
                        Console.WriteLine("Массив записан в файл {0}, нажмите Enter...", fileName);
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Введите имя файла: ");
                        fileName = Console.ReadLine();
                        Vectors.InputVector(fileName);
                        Console.WriteLine("Нажмите Enter...");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Введите имя файла: ");
                        fileName = Console.ReadLine();
                        foreach (IVector x in arr)
                        {
                            Vectors.WriteVector(x, fileName);
                        }
                        Console.WriteLine("Массив записан в файл {0}, нажмите Enter...", fileName);
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Введите имя файла: ");
                        fileName = Console.ReadLine();
                        Vectors.ReadVector(fileName);
                        Console.WriteLine("Нажмите Enter...");
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("Введите имя файла: ");
                        fileName = Console.ReadLine();
                        Vectors.SerializeVector(arr, fileName);
                        Console.WriteLine("Массив записан в файл {0}, нажмите Enter...", fileName);
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.WriteLine("Введите имя файла: ");
                        fileName = Console.ReadLine();
                        Vectors.DeserializeVector(fileName);
                        Console.WriteLine("Нажмите Enter...");
                        Console.ReadLine();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Неверный номер");
                        break;
                }
            }
        }
    }
}