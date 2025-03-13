namespace Task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int value = 0;

            int[,] a = new int[n, n];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    switch (value)
                    {
                        case 0:
                            a[i, j] = 1;
                            value = 1;
                            break;

                        case 1:
                            a[i, j] = 0;
                            value = 0;
                            break;
                    }
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
}
    }
