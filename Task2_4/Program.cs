namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullNumber;
            int number1;
            int number2;
            int number3;
            int number4;

            Console.WriteLine("Введите целое 4-x значное число");
            fullNumber = Convert.ToInt32(Console.ReadLine());

            number1 = fullNumber / 1000;
            number2 = (fullNumber / 100) % 10;
            number3 = (fullNumber / 10) % 10;
            number4 = fullNumber % 10;
            
            fullNumber = (number1 * 1000) + (number4 * 100) +(number3 * 10) + number2;

            Console.WriteLine("Результат смены 2-го и 4-го числа местами:");
            Console.WriteLine(fullNumber);
            Console.ReadLine();
        }
    }
}
