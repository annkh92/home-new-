using NLog;
using System;

namespace HW_03
{
    class Program
    {
        private static Logger log = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            log.Debug("Debug");
            log.Error("Ошибка!");
            while (true)
            {

                double n1, n2;
                string opr;

                try
                {
                    Console.WriteLine("Введите число 1");
                    n1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2");
                    n2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Выберите действие: '+', '-', '*' или '/'");
                    opr = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректное значение!");
                    Console.ReadLine();
                    continue;
                }

                switch (opr)
                {
                    case "+":
                        Console.WriteLine(n1 + n2);
                        break;
                    case "-":
                        Console.WriteLine(n1 - n2);
                        break;
                    case "*":
                        Console.WriteLine(n1 * n2);
                        break;
                    case "/":
                        if (n2 == 0)
                        {
                            Console.WriteLine("Нельзя делить на 0");
                        }
                        else
                        {
                            Console.WriteLine(n1 / n2);
                        }
                        break;
                }

            }
        }
    }
}
