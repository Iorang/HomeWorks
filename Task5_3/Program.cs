namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int minrnd = 0;
            const int maxrnd = 51;

            int max = minrnd;
            int maxIndex = 0;
            int min = maxrnd;
            int minIndex = 0;
            Random rnd = new Random();
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(minrnd, maxrnd);
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    maxIndex = i;
                }

                if (a[i] < min)
                {
                    min = a[i];
                    minIndex = i;
                }
            }

            Console.WriteLine("Значение максимального элемента: " + max);
            Console.WriteLine("Индекс максимального элемента в массиве: " + maxIndex);
            Console.WriteLine("Значение минимального элемента: " + min);
            Console.WriteLine("Индекс минимального элемента в массиве: " + minIndex);

        }
    }
}
