namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double result = 1;

            Console.WriteLine("Введите число:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                double a = 1.0 / i;
                result += 1.0/i;
            }
            
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
