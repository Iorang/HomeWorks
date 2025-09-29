namespace Task15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, uint> warehouse = new Dictionary<string, uint> { { "A001", 10 }, { "B205", 25 }, { "C307", 15 } };

            Console.WriteLine("Есть ли товар с артикулом B205? " + warehouse.ContainsKey("B205"));

            warehouse["A001"] = 8;

            if (warehouse.TryGetValue("C307", out uint value))
                Console.WriteLine("Количество наушников: " + value);

            warehouse["B205"] += 5;

            warehouse.Remove("C307");

            Console.WriteLine("Текущий инвентарь:");
            foreach (var item in warehouse)
            {
                Console.WriteLine($"Артикул: {item.Key}, Количество: {item.Value}");
            }

            warehouse.Clear();

            Console.WriteLine("Количество товаров после очистки: " + warehouse.Count);
            Console.ReadKey();

        }
    }
}
