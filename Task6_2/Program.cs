namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalString = string.Empty;
            string reversedString = string.Empty;

            while (true)
            {
                Console.WriteLine("Введите предложение:");

                originalString = Console.ReadLine();
                originalString = originalString.Replace(" ", "");
                originalString = originalString.ToLower();

                for (int i = originalString.Length - 1; i >= 0; i--)
                {
                    reversedString += originalString[i];
                }
                if (originalString.Equals(reversedString))
                {
                    Console.WriteLine("Предложение полиндром");
                }
                else
                {
                    Console.WriteLine("Предложение не полиндром");
                }
                Console.WriteLine();
            }
        }
    }
}
