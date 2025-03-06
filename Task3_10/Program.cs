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

                    case 1:
                        wordEnding = "";
                        break;
                    case 2:
                    case 3:
                    case 4:
                        wordEnding = "а";
                        break;
                    case 0:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
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
