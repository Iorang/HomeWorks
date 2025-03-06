namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int result = 1;

            Console.WriteLine("Введите число:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine(n + "!= " + result);
            Console.ReadLine();
        }
    }
}
