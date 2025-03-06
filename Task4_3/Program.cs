namespace Task4_3
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

            for (int i = 1; i < b; i++)
            {
                result *= a;
            }

            Console.WriteLine($"{a}^{b} = " + result);
            Console.ReadLine();
        }
    }
}
