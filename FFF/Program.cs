using System;

namespace FFF
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int num = 0;
            try
            {
                Console.Write("Введите натуральное число: ");
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Некорректный ввод числа");
                Console.WriteLine("-------------------------------------");
                Environment.Exit(0);
            }
            finally
            {
                if (num < 0)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Некорректный ввод числа");
                    Console.WriteLine("-------------------------------------");
                }
                else
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Вычисление факториала - \"0\"");
                    Console.WriteLine("Вывести число из ряда Фибоначчи - \"1\"");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("Команда: ");
                    int com = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------------");

                    switch (com)
                    {
                        case 0:
                            int f = 1;
                            if (num == 0) Console.WriteLine($"Факториал равен: {1}");
                            else
                            {
                                for (int i = 1; i <= num; i++)
                                {
                                    f *= i;
                                }
                            }
                            Console.WriteLine($"Факториал равен: {f}");
                            break;

                        case 1:
                            if (num == 0) Console.WriteLine($"Число из ряда Фибоначчи с порядковым номером {num} равен: {0}");
                            else if (num == 1) Console.WriteLine($"Число из ряда Фибоначчи с порядковым номером {num} равен: {1}");
                            else
                            {
                                int[] Fib = new int[num + 1];
                                for (int i = 0; i < Fib.Length; i++)
                                {
                                    if (i == 0)
                                    {
                                        Fib[i] = 0;
                                    }
                                    else if (i == 1)
                                    {
                                        Fib[i] = 1;
                                    }
                                    else
                                    {
                                        Fib[i] = Fib[i - 1] + Fib[i - 2];
                                    }
                                }
                                Console.WriteLine($"Число из ряда Фибоначчи с порядковым номером \"{num}\" равен: {Fib[num]}");
                            }
                            break;

                        default:
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Некорректная команда");
                            Console.WriteLine("-------------------------------------");
                            break;
                    }
                }
            }
        }
    }
}
