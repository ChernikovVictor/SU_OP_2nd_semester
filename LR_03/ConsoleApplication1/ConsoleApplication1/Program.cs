using System;

namespace ConsoleApplication1
{
    struct Employee
    {
        public enum Vacancies {Manager = 1, Boss, Clerk, Salesman}
        public string name;
        public Vacancies vacancy;
        public int salary;
        public DateTime hiredate;
        public override string ToString()
        {
            return name + ' ' + vacancy + ' ' + salary + " руб./мес " + hiredate.ToShortDateString();
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("ЛР-03. Черников В.Е. гр. № 6113. \n" +
                          "Программа для работы со структурой \"Рабочий\". \n" +
                          "Введите размер массива сотрудников: ");
            int n;
            Employee[] arr;
            try
            {
                n = Int32.Parse(Console.ReadLine());
                arr = new Employee[n];
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректный размер массива\nPress Enter...");
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Clear();
                Console.Write("Введите информацию о сотруднике: \n" +
                                  "Имя: ");
                arr[i].name = Console.ReadLine();
                Console.Write("1. Manager \n" +
                              "2. Boss \n" +
                              "3. Clerk \n" +
                              "4. Salesman \n" +
                              "Должность: ");
                try
                {
                    int j = Int32.Parse(Console.ReadLine());
                    switch (j)
                    {
                        case 1:
                            arr[i].vacancy = Employee.Vacancies.Manager;
                            break;
                        case 2:
                            arr[i].vacancy = Employee.Vacancies.Boss;
                            break;
                        case 3:
                            arr[i].vacancy = Employee.Vacancies.Clerk;
                            break;
                        case 4:
                            arr[i].vacancy = Employee.Vacancies.Salesman;
                            break;
                        default:
                            Console.Write("Нет такой должности (по умолчанию: Clerk)\n");
                            arr[i].vacancy = Employee.Vacancies.Clerk;
                            break;
                    }
                    Console.Write("Зарплата: ");
                    arr[i].salary = Int32.Parse(Console.ReadLine());
                    Console.Write("Дата приема на работу: ");
                    arr[i].hiredate = DateTime.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Press Enter...");
                    Console.ReadLine();
                    return;
                }
            }

            string buf = "1";
            while (buf != "0")
            {
                Console.Clear();
                Console.Write("Меню"  + "\n" +
                              "1. Список всех сотрудников" + "\n" +
                              "2. Список всех сотрудников с указанной должностью" + "\n" +
                              "3. Менеджеры, чья зарплата больше средней зарплаты всех клерков \n" +
                              "4. Сотрудники, принятые на работу позже босса \n" +
                              "0. Выход \n" +
                              "Выберете действие: ");
                buf = Console.ReadLine();
                switch (buf)
                {
                      case "1":
                          for (int i = 0; i < n; i++)
                              Console.WriteLine(arr[i]);
                          Console.WriteLine("Enter...");
                          Console.ReadLine();
                          break;
                      case "2":
                          Console.Write("1. Manager \n" +
                                        "2. Boss \n" +
                                        "3. Clerk \n" +
                                        "4. Salesman \n" +
                                        "Выберете должность: ");
                          Employee.Vacancies vac = Employee.Vacancies.Clerk;
                          try
                          {
                              int j = Int32.Parse(Console.ReadLine());
                              switch (j)
                              {
                                  case 1:
                                      vac = Employee.Vacancies.Manager; 
                                      break;
                                  case 2:
                                      vac = Employee.Vacancies.Boss; 
                                      break;
                                  case 3:
                                      vac = Employee.Vacancies.Clerk; 
                                      break;
                                  case 4:
                                      vac = Employee.Vacancies.Salesman; 
                                      break;
                                  default:
                                      Console.Write("Нет такой должности (по умолчанию: Clerk)");
                                      break;
                              }
                          }
                          catch (FormatException e)
                          {
                              Console.WriteLine(e);
                              Console.WriteLine("Press Enter...");
                              Console.ReadLine();
                              return;
                          }

                          foreach (Employee x in arr)
                          {
                              if (x.vacancy == vac)
                                  Console.WriteLine(x);
                          }
                          Console.WriteLine("Enter...");
                          Console.ReadLine();
                          break;
                      case "3":
                          Employee[] ans = new Employee[n]; // искомые менеджеры
                          double avgSalaryOfClerks = 0, countOfClerks = 0;
                          for (int i = 0; i < n; i++)
                          {
                              if (arr[i].vacancy == Employee.Vacancies.Clerk)
                              {
                                  countOfClerks += 1;
                                  avgSalaryOfClerks += arr[i].salary;
                              }
                              ans[i].name = " ";
                          }

                          if (countOfClerks != 0)
                              avgSalaryOfClerks /= countOfClerks;

                          for (int i = 0; i < n; i++)
                          {
                              if (arr[i].vacancy == Employee.Vacancies.Manager && arr[i].salary > avgSalaryOfClerks)
                              {
                                  int j = 0;
                                  ans[j] = arr[i];
                                  while (j + 1 < n && String.Compare(ans[j].name, ans[j + 1].name) > 0)
                                  {
                                      Employee swap = ans[j];
                                      ans[j] = ans[j + 1];
                                      ans[j + 1] = swap;
                                      j++;
                                  }
                              }
                          }
                          Console.WriteLine("Средняя зарплата всех клерков: {0}", avgSalaryOfClerks);
                          Console.WriteLine("Менеджеры, чья зарплата выше:");
                          foreach (Employee x in ans)
                          {
                              if (x.name != " ")
                                  Console.WriteLine(x);
                          }
                          Console.WriteLine("Enter...");
                          Console.ReadLine();
                          break;
                      case "4":
                          Employee[] answer = new Employee[n];
                          DateTime hiredateOfBoss = DateTime.Now;
                          for (int i = 0; i < n; i++)
                          {
                              if (arr[i].vacancy == Employee.Vacancies.Boss)
                              {
                                  hiredateOfBoss = arr[i].hiredate;
                              }
                              answer[i].name = " ";
                          }
                          for (int i = 0; i < n; i++)
                          {
                              if (arr[i].hiredate > hiredateOfBoss)
                              {
                                  int j = 0;
                                  answer[j] = arr[i];
                                  while (j + 1 < n && String.Compare(answer[j].name, answer[j + 1].name) > 0)
                                  {
                                      Employee swap = answer[j];
                                      answer[j] = answer[j + 1];
                                      answer[j + 1] = swap;
                                      j++;
                                  }
                              }
                          }
                          Console.WriteLine("Дата прихода босса: " +  hiredateOfBoss.ToShortDateString());
                          Console.WriteLine("Сотрудники, которых наняли позже:");
                          foreach (Employee x in answer)
                          {
                              if (x.name != " ")
                                  Console.WriteLine(x);
                          }
                          Console.WriteLine("Enter...");
                          Console.ReadLine();
                          break;
                      case "0":
                          break;
                }
            }
        }
    }
}