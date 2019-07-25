using System;
using Microsoft.Win32;

namespace ConsoleApplication1
{
    delegate void Del();
    internal class Program
    {
        public static IVector[] arr;
        
        // 1 пункт меню: Самые маленькие вектора
        public static void Action1()
        {
            Console.WriteLine("Выполняется 1 пункт меню");
            IVector minVector = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(minVector) < 0)
                    minVector = arr[i];
            }
            Console.WriteLine("Самые маленькие вектора:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(minVector) == 0)
                    Console.WriteLine(arr[i].ToString());
            }
            Console.WriteLine("Конец 1 пункта меню. Нажмите Enter...");
            Console.ReadLine();
        }
        
        // 2 пункт меню: Самые большие вектора
        public static void Action2()
        {
            Console.WriteLine("Выполняется 2 пункт меню");
            IVector maxVector = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(maxVector) > 0)
                    maxVector = arr[i];
            }
            Console.WriteLine("Самые большие вектора:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(maxVector) == 0)
                    Console.WriteLine(arr[i].ToString());
            }
            Console.WriteLine("Конец 2 пункта меню. Нажмите Enter...");
            Console.ReadLine();
        }
        
        // 3 пункт меню: Сортировка по возрастанию модулей
        public static void Action3()
        {
            Console.WriteLine("Выполняется 3 пункт меню \n" +
                              "Вектора сортированы по возрастанию модулей:");
            Array.Sort(arr, new LinkedListVector.SortByNorm());
            foreach (IVector x in arr)
            {
                Console.WriteLine(x.ToString());
            }
            Console.WriteLine("Конец 3 пункта меню. Нажмите Enter...");
            Console.ReadLine();
        }
        
        // 4 пункт меню: Сортировка по кол-ву координат
        public static void Action4()
        {
            Console.WriteLine("Выполняется 4 пункт меню \n" +
                              "Вектора сортированы по кол-ву координат:");
            Array.Sort(arr);
            foreach (IVector x in arr)
            {
                Console.WriteLine(x.ToString());
            }
            Console.WriteLine("Конец 4 пункта меню. Нажмите Enter...");
            Console.ReadLine();
        }
        
        // 5 пункт меню: Клонирование вектора
        public static void Action5()
        {
            Console.WriteLine("Выполняется 5 пункт меню \n" +
                              "Выберете номер массива (1, 2, 3, ...):");
            int j;
            IVector clone;
            try
            {
                j = Int32.Parse(Console.ReadLine());
                j--;
                clone = (IVector)arr[j].Clone();
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректный индекс\nPress Enter...");
                Console.ReadLine();
                return;
            }
            for (int i = 0; i < clone.Length; i++)
                clone[i] = 5;
            Console.WriteLine("Заменили в клоне все элементы на значение: 5 \n" +
                              clone.ToString() + "\n" +
                              "Исходный вектор не изменился: \n" +
                              arr[j].ToString());
            Console.WriteLine("Конец 5 пункта меню. Нажмите Enter...");
            Console.ReadLine();
        }
        
        public static void Main(string[] args)
        {
            // создание массива
            Console.Write("ЛР-07. Черников В.Е. гр. № 6113. \n" +
                          "Программа для работы с векторами и односвязными списками,\n" +
                          "реализующими несколько стандарнтых интерфейсов (c использованием делегатa) \n" +
                          "Введите колличество векторов в массиве: ");
            int n = Int32.Parse(Console.ReadLine());
            arr = new IVector[n];
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
                    Console.WriteLine("Неверный формат записи");
                    throw;
                }
                arr[i] = x;
            }
            
            // Меню
            Console.Clear();
            foreach (IVector x in arr)
            {
                Console.WriteLine(x.ToString());
            }
            Console.Write("Введите последовательность пунктов меню, которая должна быть выполнена:\n" +
                              "1. Найти самые маленькие вектора\n" +
                              "2. Найти самые большие вектора\n" +
                              "3. Сортировать массив по возрастанию модулей\n" +
                              "4. Сортировать массив по кол-ву координат\n" +
                              "5. Клонировать произвольный вектор\n" +
                              "Последовательность (в строчку, без пробелов): ");
            string buf = Console.ReadLine();
            Del delegateForMenu = null;
            foreach (char ch in buf)
            {
                switch (ch)
                {
                    case '1':
                        delegateForMenu += Action1;
                        break;
                    case '2':
                        delegateForMenu += Action2;
                        break;
                    case '3':
                        delegateForMenu += Action3;
                        break;
                    case '4':
                        delegateForMenu += Action4;
                        break;
                    case '5':
                        delegateForMenu += Action5;
                        break;
                }
            }

            // запуск делегата
            delegateForMenu();
        }
    }
}