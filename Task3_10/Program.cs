namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string wordEnding = "";

            Console.WriteLine("Сколько домов построил застройщик?:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 100 <= 10 || number % 100 >= 20)
            {
                switch (number % 10)
                {
                    case 0:
                        wordEnding = "ов";
                        break;

                    case 1:
                        wordEnding = "";
                        break;

                    case 2:
                        wordEnding = "а";
                        break;

                    case 3:
                        wordEnding = "а";
                        break;
                    case 4:
                        wordEnding = "а";
                        break;
                    case 5:
                        wordEnding = "ов";
                        break;
                    case 6:
                        wordEnding = "ов";
                        break;
                    case 7:
                        wordEnding = "ов";
                        break;
                    case 8:
                        wordEnding = "ов";
                        break;
                    case 9:
                        wordEnding = "ов";
                        break;
                }
            }
            else
            {
                wordEnding = "ов";
            }

            Console.WriteLine("Застройщик построил {0} дом{1}", number, wordEnding);
            Console.ReadLine();
        }
    }
}
