namespace Task3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullNumber;

            Console.WriteLine("Введите 3-х значное целое число:");
            fullNumber = Convert.ToInt32(Console.ReadLine());

            if (fullNumber < 1000 && fullNumber >= 100)
            {
                int firstNumber = fullNumber / 100;
                int secondNumber = (fullNumber / 10) % 10;
                int thirdNumber = fullNumber % 10;

                string firstTextNumber = "";
                string secondTextNumber = "";
                string thirdTextNumber = "";

                switch (firstNumber)
                {
                    case 1:
                        firstTextNumber = "Сто";
                        break;
                    case 2:
                        firstTextNumber = "Двести";
                        break;
                    case 3:
                        firstTextNumber = "Триста";
                        break;
                    case 4:
                        firstTextNumber = "Четыреста";
                        break;
                    case 5:
                        firstTextNumber = "Пятьсот";
                        break;
                    case 6:
                        firstTextNumber = "Шестьсот";
                        break;
                    case 7:
                        firstTextNumber = "Семьсот";
                        break;
                    case 8:
                        firstTextNumber = "Восемьсот";
                        break;
                    case 9:
                        firstTextNumber = "Девятьсот";
                        break;
                }

                if (secondNumber != 1)
                {
                    switch (secondNumber)
                    {

                        case 2:
                            secondTextNumber = "двадцать";
                            break;
                        case 3:
                            secondTextNumber = "тридцать";
                            break;
                        case 4:
                            secondTextNumber = "сорок";
                            break;
                        case 5:
                            secondTextNumber = "пятьдесят";
                            break;
                        case 6:
                            secondTextNumber = "шестьдесят";
                            break;
                        case 7:
                            secondTextNumber = "семьдесят";
                            break;
                        case 8:
                            secondTextNumber = "восемьдесят";
                            break;
                        case 9:
                            secondTextNumber = "девяносто";
                            break;
                    }

                    switch (thirdNumber)
                    {

                        case 1:
                            thirdTextNumber = "один";
                            break;
                        case 2:
                            thirdTextNumber = "два";
                            break;
                        case 3:
                            thirdTextNumber = "три";
                            break;
                        case 4:
                            thirdTextNumber = "четыре";
                            break;
                        case 5:
                            thirdTextNumber = "пять";
                            break;
                        case 6:
                            thirdTextNumber = "шесть";
                            break;
                        case 7:
                            thirdTextNumber = "семь";
                            break;
                        case 8:
                            thirdTextNumber = "восемь";
                            break;
                        case 9:
                            thirdTextNumber = "девять";
                            break;
                    }
                }
                else
                {
                    int secondAndThirdNumbers = secondNumber * 10 + thirdNumber;
                    switch (secondAndThirdNumbers)
                    {
                        case 10:
                            secondTextNumber = "десять";
                            break;
                        case 11:
                            secondTextNumber = "одинадцать";
                            break;
                        case 12:
                            secondTextNumber = "двенадцать";
                            break;
                        case 13:
                            secondTextNumber = "тринадцать";
                            break;
                        case 14:
                            secondTextNumber = "четырнадцать";
                            break;
                        case 15:
                            secondTextNumber = "пятнадцать";
                            break;
                        case 16:
                            secondTextNumber = "шестнадцать";
                            break;
                        case 17:
                            secondTextNumber = "семнадцать";
                            break;
                        case 18:
                            secondTextNumber = "восемнадцать";
                            break;
                        case 19:
                            secondTextNumber = "девятнадцать";
                            break;
                    }
                }

                Console.WriteLine("Число в текстовом представлении:");
                Console.WriteLine("{0} {1} {2}", firstTextNumber, secondTextNumber, thirdTextNumber);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Введено не трехзначное число");
                Console.ReadLine();
            }
        }
    }
}
