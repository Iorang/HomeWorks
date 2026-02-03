namespace Task3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal finalprice;
            var itemsWithQuantities = new Dictionary<decimal, int>() { { 25, 1 }, { 10, 3 }, { 15, 2 } };
            var customerType = "Regular";

            var shoppingCartService = new ShoppingCartService();
            var refactoredShoppingCartService = new RefactoredShoppingCartService();

            finalprice = shoppingCartService.CalculateTotalPriceWithQuantities(customerType, itemsWithQuantities);
            finalprice = refactoredShoppingCartService.CalculateTotalPriceWithQuantities(customerType, itemsWithQuantities);

            Console.ReadLine();

        }
    }
}
