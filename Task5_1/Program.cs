namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int even = 0;
            int notEven = 0;
            int remains;
            Random rnd = new Random();
            int[] a = new int[n];

            for (int i = 0; i < n; i++) 
            {
                a[i] = rnd.Next(0,101);
            }

            foreach (var item in a)
            {
                remains = item % 2;
                if (remains == 0)
                {
                    even++;
                }
                else
                {
                    notEven++;
                }
            }

            Console.WriteLine((even > notEven) ? ("Четных чисел больше чем нечетных") : (even < notEven) ? ("Нечетных чисел больше чем четных") : ("Количество четных и нечетных чисел равно"));

        }

    }
}
