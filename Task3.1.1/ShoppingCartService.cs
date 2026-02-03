using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1._1
{
    public class ShoppingCartService
    {
        /*
         * Нарушения YAGNI:
         *  - Реализация логики на будущее в виде учета других типов покупателей кроме regular
         *  
         * Нарушения KISS:
         *  - Цикл for в методе CalculateTotalPrice можно заменить на itemPrices.Sum()
         *  - Вложенный цикл for в методе CalculateTotalPriceWithQuantities можно заменить на вычичление общей суммы
         * 
         * Нарушения DКН:
         *  - Я бы объеденил оба метода в один с одной входной переменной Dictionary<decimal, int> itemsWithQuantities, но, как я понял, 
         *    такой вариант не предусмотрен условием задания т.к. поменяются входные данные методов и сами методы в классе.
         *    Других нарушений DRY я не нашел.
         */
        public decimal CalculateTotalPrice(string customerType, List<decimal> itemPrices)
        {
            decimal baseTotal = 0;
            for (int i = 0; i < itemPrices.Count; i++)
            {
                baseTotal += itemPrices[i];
            }

            decimal discount = 0;

            if (customerType == "Regular")
            {
                discount = baseTotal * 0.05m; // 5%
            }
            else if (customerType == "Premium")
            {
                discount = baseTotal * 0.15m; // 15%
                if (discount > 1000)
                {
                    discount = 1000 + (discount - 1000) * 0.1m;
                }
            }
            else if (customerType == "VIP")
            {
                discount = baseTotal * 0.20m; // 20%
            }

            decimal finalPrice = baseTotal - discount;

            Console.WriteLine($"Base: {baseTotal}, Discount: {discount}, Final: {finalPrice}");
            return finalPrice;
        }

        public decimal CalculateTotalPriceWithQuantities(string customerType, Dictionary<decimal, int> itemsWithQuantities)
        {
            List<decimal> allPrices = new List<decimal>();
            foreach (var item in itemsWithQuantities)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    allPrices.Add(item.Key);
                }
            }
            return CalculateTotalPrice(customerType, allPrices);
        }
    }
}
