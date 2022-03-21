using System;

namespace A_A_A_A_A_A_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Введите 5 чисел для нахождения среднего арифметического");
            Console.WriteLine("-------------------------------------------------------");

            Console.Write("Первое число = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Третье число = ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Четвёртое число = ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Пятое число = ");
            int x5 = Convert.ToInt32(Console.ReadLine());

            float res = (float) (x1 +x2 +x3 +x4 +x5) / 5;

            Console.WriteLine("-------------------------");
            Console.WriteLine("Среднее арифметическое: " + $"{res}") ;
            Console.WriteLine("-------------------------");
        }
    }
}
