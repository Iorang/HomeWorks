namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double d;
            double maxNumber;


            Console.WriteLine("Введите 4 разных числа:");

            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.Write("d = ");
            d = Convert.ToDouble(Console.ReadLine());

            maxNumber = a;
            if (b > maxNumber)
            {
                maxNumber = b;
            }
            if (c > maxNumber)
            {
                maxNumber = c;
            }
            if (d > maxNumber)
            {
                maxNumber = d;
            }


            Console.WriteLine("Наибольшее из чисел число: " + maxNumber);

            Console.ReadLine();
        }
    }
}
