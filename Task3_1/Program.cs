using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;

            Console.WriteLine("Введите число 1:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число 2:");
            b = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Результат сравнения:");

            Console.WriteLine((a == b) ? (a + " = " + b) : (a > b) ? (a + " > " + b) : (a + " < " + b));

            Console.ReadLine();

        }
    }
}
