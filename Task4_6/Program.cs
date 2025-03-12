namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int result;
            int n = 0;

            Console.WriteLine("Введите число a:");
            a = Convert.ToInt32(Console.ReadLine());

            result = a;

            while (result != 0)
            {
                result /= 10;
                n++;
            }

            Console.WriteLine($"В числе {a} количество цифр равно: {n}");
            Console.ReadLine();
        }
    }
}
