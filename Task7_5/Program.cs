namespace Task7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2, 3)); // Вывод: 6
            Console.WriteLine(Multiply(2.5, 3.5)); // Вывод: 8.75
            Console.ReadLine();
        }
        static int Multiply(int a, int b)
        {
            int multiplyResult = a * b;
            return multiplyResult;
        }

        static double Multiply(double a, double b)
        {
            double multiplyResult = a * b;
            return multiplyResult;
        }

    }
}
