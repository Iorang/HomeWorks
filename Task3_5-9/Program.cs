using System;

namespace Task3_5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;

            Console.WriteLine("Введите число:");
            number = Convert.ToDouble(Console.ReadLine());

            //Task3_5
            Console.Write("Число оканчивается на ноль?: ");
            if ((number % 10) == 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }

            //Task3_6
            Console.Write("Число является четным?: ");
            if ((number % 2) == 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }

            //Task3_7
            Console.Write("Число является двухзначным?: ");
            if ((number / 100) > 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }

            //Task3_8
            Console.Write("Число попадает в диапазон [-10,10]?: ");
            if (number <= 10 && number >= -10)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }

            //Task3_9
            Console.Write("Число попадает в диапазон (-∞; -10] Ս [10; +∞)?: ");
            if (number <= -10 || number >= 10)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
        }
    }
}
