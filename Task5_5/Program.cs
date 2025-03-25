namespace Task5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int minrnd = -50;
            const int maxrnd = 51;

            int minseparator = 0; 
            int maxseparator = 5;
            int counter = 0;

            Random rnd = new Random();
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(minrnd, maxrnd);
            }

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            while (counter != a.Length)
            {
                for (int i = minseparator; i < maxseparator; i++)
                {
                    for (int j = i + 1; j < maxseparator; j++)
                    {
                        if (a[i] > a[j])
                        {
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                    counter++;
                }
                maxseparator += counter;
                minseparator += counter;
            }

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
