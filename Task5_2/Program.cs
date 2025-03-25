namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int positive = 0;
            int negative = 0;
            int nullable = 0;
            Random rnd = new Random();
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(-21, 20);
            }

            foreach (var item in a)
            {

                if (item > 0)
                {
                    positive++;
                }
                if (item < 0)
                {
                    negative++;
                }
                if (item == 0)
                {
                    nullable++;
                }
            }

            Console.WriteLine("Количество положительных чисел: " + positive);
            Console.WriteLine("Количество отрицательных чисел: " + negative);
            Console.WriteLine("Количество чисел равных нулю: " + nullable);

        }
    }
}
