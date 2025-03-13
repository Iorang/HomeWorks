namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 5;
            const int minrnd = 0;
            const int maxrnd = 11;

            int maxValue = minrnd;

            Random rnd = new Random();
            int[,] a = new int[n,m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i,j] = rnd.Next(minrnd, maxrnd);
                    maxValue = a[i, j] > maxValue ? a[i, j] : maxValue;
                    Console.Write("{0,-4}", a[i, j]);
                }
                Console.Write("Max = " + maxValue);
                Console.WriteLine();
                maxValue = minrnd;
            } 
        }
    }
}
