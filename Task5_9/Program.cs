namespace Task5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int m = 5;
            const int n = 5;

            int a = 0;
            int b = 0;

            int value = 0;

            int[,] array = new int[m, n];

            for (int i = a; i < m; i++)
            {
                value++;
                array[i, b] = value;
                a++;
            }

            for (int i = b+1; i < n; i++)
            {
                b++;
                value++;
                array[a-1, i] = value;
            }

            for (int i = a-2; i >= 0; i--)
            {
                value++;
                array[i, b] = value;
                a--;
            }

            for (int i = b - 2; i >= 0; i++)
            {
                value++;
                array[a, i] = value;
                b--;
            }



            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,-4}", array[j, i]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
