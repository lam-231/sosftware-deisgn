using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum ProductCategory
    {
        Food,
        Electronics,
        Clothing,
        Books,
        Furniture
    }
    public class ProductWithCategory : Product
    {
        public ProductCategory Category { get; set; }

        public ProductWithCategory(string name, Money price, ProductCategory category) : base(name, price)
        {
            Category = category;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price.Display}, Category: {Category}");
        }
    }
}
