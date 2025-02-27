namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;

            Console.WriteLine("Введите число:");
            number = Convert.ToDouble(Console.ReadLine());

            number =  Math.Round(number,0, MidpointRounding.ToPositiveInfinity);

            Console.WriteLine("Результат округления в большую сторону до целого числа:");
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
