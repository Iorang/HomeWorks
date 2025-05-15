namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int operationCode;
            bool notValidOperationCode;
            double result = 0;
            while (true)
            {
                Console.WriteLine("Введите два целых числа:");
                try
                {
                    Console.Write("Число 1 = ");
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Число 2 = ");
                    secondNumber = Convert.ToInt32(Console.ReadLine());

                    notValidOperationCode = true;
                    while (notValidOperationCode)
                    {
                        Console.WriteLine("Введите код опперации: \n1 - \"+\"\n2 - \"-\"\n3 - \"*\"\n4 - \"/\"");
                        Console.Write("Код опперации = ");
                        try
                        {
                            operationCode = Convert.ToInt32(Console.ReadLine());
                            if (operationCode < 1 || operationCode > 4)
                                throw new FormatException();

                            if (operationCode == 1)
                            {
                                result = firstNumber + secondNumber;
                            }
                            if (operationCode == 2)
                            {
                                result = firstNumber - secondNumber;
                            }
                            if (operationCode == 3)
                            {
                                result = firstNumber * secondNumber;
                            }
                            if (operationCode == 4)
                            {
                                result = (double)firstNumber / secondNumber;
                            }
                            notValidOperationCode = false;
                            Console.WriteLine($"Результат вычисления = {result}\n");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ошибка! Не верный код опперации\n");
                            continue;
                        }
                    }

                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка! Деление на 0\n");
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введено не целое число\n");
                    continue;
                }
            }



        }
    }
}
