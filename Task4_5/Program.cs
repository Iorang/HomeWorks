namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            double result;

            Console.WriteLine("Введите число a:");
            a = Convert.ToInt32(Console.ReadLine());

            result = a;

            while (result != 2) 
            {
                if (result < 2)
                    break;
                result /= 2;
            }
            
            Console.WriteLine((result == 2) ? ($"Число {a} является степенью числа 2") : ($"Число {a} не является степенью числа 2"));
            Console.ReadLine();
        }
    }
}
