namespace Task2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            double resultNumber;

            Console.WriteLine("Введите число:");
            number = Convert.ToDouble(Console.ReadLine());

            number = Math.Round((number /0.5), 0) * 0.5;

            Console.WriteLine("Результат округления c шагом 0,5:");
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
