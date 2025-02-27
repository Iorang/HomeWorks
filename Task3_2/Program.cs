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


            Console.WriteLine("Введите 4 разных числа:");

            Console.WriteLine("a = ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("b = ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("c = ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("d = ");
            d = Convert.ToDouble(Console.ReadLine());


            if (d > a && d > b && d > c)
            {
                Console.WriteLine("Наибольшее из чисел число: d = " + d);
            }
            else
            {
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
            }
            Console.ReadLine();
        }
    }
}
