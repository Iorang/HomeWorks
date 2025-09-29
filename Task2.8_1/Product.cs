using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8_1
{
    
    public enum ProductCategory
    {
        Eat,
        Appliances
    }
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImagePath {  get; set; }
        public ProductCategory Category {  get; set; }
    }
}
