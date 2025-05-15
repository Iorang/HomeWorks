namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2025;
            string mounth = "Март";
            decimal totalAmount = 1598263.56m;
            int numberOfProductSold = 1148;
            decimal averageCost;

            averageCost = totalAmount / numberOfProductSold;
            Console.WriteLine(new string('─', 40));
            Console.WriteLine($"Отчет о продажах за {mounth} {year}:");
            Console.WriteLine(new string('─', 40));
            Console.WriteLine("Общая сумма продаж: {0:N2} р.", totalAmount);
            Console.WriteLine("Количество проданных товаров: {0,0} шт.", numberOfProductSold);
            Console.WriteLine("Средняя стоимость товара: {0:N2} р.", averageCost);
            Console.WriteLine(new string('─', 40));
            Console.ReadLine();

        }
    }
}
