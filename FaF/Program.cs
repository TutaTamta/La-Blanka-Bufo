using System;

namespace FaF
{
    class Program
    {
       static int[,] Mass(int x, int y)
        {
            int[,] mass = new int [x,y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mass[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return mass;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите кол-во строк: ");
            Console.Write("Введите кол-во строк: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите кол-во столбцов: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] masA = new int [rows, cols];
            int[,] masB = new int[rows, cols];
            int[,] result = new int[rows, cols];

            masA = Mass(rows,cols);
            masB = Mass(rows, cols);

            Console.WriteLine("Сложение - \"1\"");
            Console.WriteLine("Вычитание - \"2\"");
            int com = int.Parse(Console.ReadLine());

            switch(com)
            {
                case 1:
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < cols; j++)
                            {
                                result[i, j] = masA[i, j] + masB[i, j];
                            }
                        }

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < cols; j++)
                            {
                                Console.Write($"{result[i, j]} \t");
                            }
                            Console.WriteLine();
                        }

                        break;
                    }

                case 2:
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < cols; j++)
                            {
                                masB[i, j] = masB[i, j] * -1;
                            }
                        }

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < cols; j++)
                            {
                                result[i, j] = masA[i, j] + masB[i, j];
                            }
                        }

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < cols; j++)
                            {
                                Console.Write($"{result[i, j]} \t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
            }
        }
    }
}
