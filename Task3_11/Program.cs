using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double a;
            double b;

            double p;
            double q;

            double r;
            double s;

            Console.WriteLine("Длина участка");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ширина участка");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Длина первого дома");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ширина первого дома");
            q = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Длина второго дома");
            r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ширина второго дома");
            s = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Ответ:");
            //Не понял как можно решить задачу используя конструкцию SWITCH!
            if (p + r <= a && q + s <= b)
            {
                Console.WriteLine("Дома помещаются на участке");
            }
            else
            {
                Console.WriteLine("Дома не помещаются на участке");
            }

        }
    }
}
