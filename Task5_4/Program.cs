using System.Diagnostics.Metrics;

namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int minrnd = 0;
            const int maxrnd = 11;

            Random rnd = new Random();
            int[] a = new int[n];
            int[] b = new int[n];

            int counter;

            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(minrnd, maxrnd);
            }

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }

            counter = a.Length - 1;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = b[counter];
                counter--;
            }

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
