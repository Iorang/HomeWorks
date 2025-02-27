namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Введите 3 разных числа:");
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());


                if (c > b && c > a)
                {
                    Console.WriteLine("Наибольшее из чисел число: c = " + c);
                }
                else
                {
                    if (b > a)
                    {
                        Console.WriteLine("Наибольшее из чисел число: b = " + b);
                    }
                    else
                    {
                        Console.WriteLine("Наибольшее из чисел число: a = " + a);
                    }
                }
            Console.ReadLine();
        }
    }
}
 