namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int result;
            int n = 0;

            Console.WriteLine("Введите число:");
            a = Convert.ToInt32(Console.ReadLine());

            result = a;

            while (result != 0)
            {
                result /= 10;
                n++;
            }

            result = 0;

            for (int i = n; i != 0; i--)
            {
                int number = a % 10;
                a /= 10;
                int dec = 1;

                for (int k = i-1; k != 0; k--)
                {
                    dec *= 10; 
                }

                result += number  * dec;
            }
            

            Console.WriteLine("Отзекркаленное число:");
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
