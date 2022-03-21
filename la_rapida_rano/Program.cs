using System;

namespace la_rapida_rano
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int persona = 6;

            // Текст, описывающий общий плани причину сбора (она любит наблюдать и анализировать. И немного терроризировать). Она из 305 квартиры.

            while (persona != 0)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1 - молодожены из 301 квартиры" + "\n" + "2 - старушка-божий-одуванчик из 309 квартиры" + "\n" + "3 - Генадий \"Просвещенный\" из 302 квартиры" + "4 - профессор на пенсии из 306 квартиры" + "\n" + "0 - продолжить чаепитие");
                Console.WriteLine("---------------------------------");
                // 1 - молодожены из 301 квартиры
                // 2 - старушка-божий-одуванчик из 309 квартиры
                // 3 - Генадий "Просвещенный" из 302 квартиры
                // 4 - профессор на пенсии из 306 квартиры
                // 0 - продолжить чаепитие

                Console.Write("Вариант: ");
                persona = Convert.ToInt32(Console.ReadLine());

                switch (persona)
                {
                    case 1:
                        Console.WriteLine("\n");
                        Console.WriteLine("Описание парочки");
                        break;

                    case 2:
                        Console.WriteLine("\n");
                        Console.WriteLine("Описание бабульки");
                        break;

                    case 3:
                        Console.WriteLine("\n");
                        Console.WriteLine("Описание Генадия");
                        break;

                    case 4:
                        Console.WriteLine("\n");
                        Console.WriteLine("Описание профессора");
                        break;

                    default:
                        break;
                }

                // Нервная посиделка продолжается, но рано илипоздно гости расходятся, а ГГ обнаруживает пропажу соли.
                // Начинается расследование

                // Приход к персонажу и начало диалога
            }
        }
    }
}
