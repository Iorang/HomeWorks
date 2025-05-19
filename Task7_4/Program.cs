namespace Task7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = FindMax(10, 25, 5, 30, 15);
            Console.WriteLine($"Максимальное число: {maxNumber}"); 
            Console.ReadLine();
        }
        private static int FindMax(params int[] numbers)
        {
            int sum = numbers[0];

            for (int i = 1; i < numbers.Count(); i++)
            {
                if (sum < numbers[i])
                {
                    sum = numbers[i];
                }
            }

            return sum;
        }
    }
}
