using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример вызова:
            int[] numbers = { 1, 2, 3, 4, 5 };
            PrintNumbers(numbers); 
            Console.WriteLine();
            PrintNumbers(numbers, true);
            Console.ReadLine();
        }

        public static void PrintNumbers(int[] numbers, bool reverse = false)
        {
            if (reverse)
            {
                for (int i = numbers.Count() - 1; i > -1; i--)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            else
            {
                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
