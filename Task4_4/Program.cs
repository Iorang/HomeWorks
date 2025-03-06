namespace Task4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double result;

            Console.WriteLine("Введите число a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число b:");
            b = Convert.ToDouble(Console.ReadLine());

            result = a;

            for (int i = 0; i >= b; i--)
            {
                result *= 1.0/a;
            }

            Console.WriteLine($"{a}^{b} = " + result);
            Console.ReadLine();
        }
    }
}

