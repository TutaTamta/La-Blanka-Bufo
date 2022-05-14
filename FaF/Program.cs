﻿using System;

namespace FaF
{
    class Program
    {
        static int[,] Mass(int x, int y)
        {
            int[,] mass = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mass[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return mass;
        }

        static void Result(int[,] result, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write("~~~~~~~~~");
                    }
                    Console.WriteLine();
                }

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{result[i, j]} \t");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < cols; j++)
            {
                Console.Write("~~~~~~~~~");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("~ Если хотите найти обратную матрицу, первая матрица дожна быть квадратной и её ранг не должен быть больше трёх ~");
            Console.Write("Введите кол-во строк: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите кол-во столбцов: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] masA = new int[rows, cols];
            int[,] masB = new int[rows, cols];
            int[,] result = new int[rows, cols];

            Console.WriteLine("Введите числа первого массива");
            masA = Mass(rows, cols);
            Console.WriteLine("Введите числа второго массива");
            masB = Mass(rows, cols);

            Console.WriteLine("-----------------------");
            Console.WriteLine("Сложение - \"1\"");
            Console.WriteLine("Вычитание - \"2\"");
            Console.WriteLine("Обратная матрица (для первой матрицы) - \"3\"");
            Console.Write("Команда: ");
            int com = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            switch (com)
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

                        Result(result, rows, cols);

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

                        Result(result, rows, cols);

                        break;
                    }

                case 3:
                    {
                        int opr = 0;

                        if (rows == cols && rows == 2)
                        {
                            //Нахождение об мат для 2 квад

                            opr = masA[0, 0] + masA[1, 1] - masA[0, 1] - masA[1, 0];

                            if (opr != 0)
                            {
                                result[0, 0] = masA[1, 1];
                                result[0, 1] = -masA[1, 0];
                                result[1, 0] = -masA[0, 1];
                                result[1, 1] = masA[0, 0];

                                int k = 0;

                                for (int i = 0; i < rows; i++)
                                {
                                    for (int j = k; j < cols; j++)
                                    {
                                        if (i != j)
                                        {
                                            int temp = result[i, j];
                                            result[i, j] = result[j, i];
                                            result[j, i] = temp;
                                        }
                                    }
                                    k++;
                                }

                                Console.WriteLine($"Обратная матрица: (1/{opr}) * ");
                                Result(result, rows, cols);
                            }
                            else
                            {
                                Console.WriteLine("Невозможно найти обратную матрицу");
                            }
                        }
                        else if (rows == cols && rows == 3)
                        {
                            //Нахождение обр матрицы для ранга 3

                            opr = masA[0, 0] * (masA[1, 1] + masA[2, 2] - masA[2, 1] - masA[1, 2]) - masA[0, 1] * (masA[1, 0] + masA[2, 2] - masA[2, 0] - masA[1, 2] + masA[0, 2] * (masA[1, 0] + masA[2, 1] - masA[1, 1] + masA[2, 0]));
                            // Не закончен
                        }
                        else if (rows > 3)
                        {
                            Console.WriteLine("Ранг матрицы больше трёх");
                        }
                        else if (rows == cols)
                        {
                            Console.WriteLine("Для нахождения обратной матрицы необходима квадратная матрица");
                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Некорректная команда");
                        break;
                    }
            }
        }
    }
}
