using System;

namespace Shush
{
    internal class Program
    {
        static int[] RandNum(int[] rand)
        {
            for (int i = 0; i < rand.Length; i++)
            {
                Random r = new Random();
                rand[i] = r.Next(1, 100);
            }
            return rand;
        }

        static void PrintArr(int[] rand)
        {
            foreach (int i in rand)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] num = new int[100];
            float sum = 0;
            double mult = 1;

            RandNum(num);
            PrintArr(num);

            Console.WriteLine("-----------------------------");
            Console.Write("         Команда: ");
            int comd = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            switch (comd)
            {
                case 0:
                    {
                        for (int i = 0; i < num.Length; i++)
                        {
                            sum += (float)num[i];
                        }

                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine($"| Среднее арифметическое равно: {sum / 100} |");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        break;
                    }

                case 1:
                    {
                        for (int i = 0; i < num.Length; i++)
                        {
                            mult *= num[i];
                        }

                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine($"| Среднее геометрическое равно: {Math.Pow(mult, 1/100.0)} |");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        break;
                    }

                case 2:
                    {
                        for (int i = 0; i < num.Length; i++)
                        {
                            sum += (num[i] * num[i]);
                        }

                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine($"| Среднее квадратическое равно: {Math.Pow(sum / 100, 1 / 2.0)} |");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        break;
                    }
            }
        }
    }
}
