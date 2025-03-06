namespace Task3_4
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


            if (c > b && c < a)
            {
                Console.WriteLine("Медианное число: c = " + c);
            }
            else
            {
                if (b > a && b < c)
                {
                    Console.WriteLine("Медианное число: b = " + b);
                }
                else
                {
                    Console.WriteLine("Медианное число: a = " + a);
                }
            }
            Console.ReadLine();
        }
    }
}
