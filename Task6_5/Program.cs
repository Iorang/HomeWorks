using System.Text.RegularExpressions;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber;
            string pattern = @"^\+[0-9]{1}\([0-9]{3}\)[0-9]{3}-[0-9]{2}-[0-9]{2}$";
            while (true)
            {
                Console.WriteLine("Введите номер телефона:");
                phoneNumber = Console.ReadLine();

                Regex regex = new Regex(pattern);
                if (regex.IsMatch(phoneNumber))
                {
                    Console.WriteLine("{0} - Да", phoneNumber);
                }
                else
                {
                    Console.WriteLine("{0} - Нет", phoneNumber);
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
