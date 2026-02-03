using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1._1
{
    public class RefactoredShoppingCartService
    {
        
        public decimal CalculateTotalPrice(string customerType, List<decimal> itemPrices)
        {
            
            //Цикл суммирования заменен на метод Sum()
            var baseTotal = itemPrices.Sum();

            //Удален функционал других видов скидок
            var discount = baseTotal * 0.05m; // 5%

            decimal finalPrice = baseTotal - discount;

            Console.WriteLine($"Base: {baseTotal}, Discount: {discount}, Final: {finalPrice}");
            return finalPrice;
        }

        public decimal CalculateTotalPriceWithQuantities(string customerType, Dictionary<decimal, int> itemsWithQuantities)
        {
            List<decimal> allPrices = new List<decimal>();
            foreach (var item in itemsWithQuantities)
            {
                //Удален вложенный цикл и добавлено вычисление
                var summ = item.Key * item.Value;

                allPrices.Add(summ);
            }
            return CalculateTotalPrice(customerType, allPrices);
        }
    }
}
