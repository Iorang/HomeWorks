using System.Security.Cryptography.X509Certificates;

namespace Task14_1
{
    internal class Program
    {
        public delegate int Transformer(int number);
        static void Main(string[] args)
        {

            int[] numbers = [5,25,-8];
            foreach (int number in numbers)
            {
                Console.Write(number + " "); 
            }
            Console.WriteLine();

            //Удвоение
            int[] transformnumbers = Transform(numbers, n => n * 2);

            foreach (int number in transformnumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //Возведение в квадрат
            transformnumbers = Transform(numbers, n => n * n);

            foreach (int number in transformnumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //замена чисел на их модули
            transformnumbers = Transform(numbers, n => (int)Math.Sqrt(n * n));

            foreach (int number in transformnumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        public static int[] Transform (int[] intNumbers, Transformer transformer)
        {
            int[] result = new int[intNumbers.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = transformer(intNumbers[i]);
            }
            return result;
        }
    }
}
