using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopClassLibrary;

namespace masster
{
    class Program
    {
        static void Main(string[] args)
        {

            Money money = new Money(100, 50);
            Console.WriteLine("Початкова сума:");
            money.Display(); 

            money.DecreaseAmount(20, 25);
            Console.WriteLine("Сума після зменшення:");
            money.Display(); 

            Product product = new Product("Apple", new Money(10, 99));
            Console.WriteLine("\nІнформація про продукт:");
            Console.WriteLine($"Назва: {product.Name}, Ціна: {product.Price}");

            product.ReducePrice(5, 50);
            Console.WriteLine("Ціна після знижки:");
            product.Price.Display(); 

            ProductWithCategory productWithCategory = new ProductWithCategory("Laptop", new Money(1500, 0), ProductCategory.Electronics);
            Console.WriteLine("\nІнформація про продукт з категорією:");
            productWithCategory.DisplayProductInfo(); 

            Warehouse warehouseItem = new Warehouse("Smartphone", "pcs", new Money(500, 0), 10, DateTime.Now);
            Console.WriteLine("\nІнформація про товар на складі:");
            Console.WriteLine($"Товар: {warehouseItem.ProductName}, Одиниця: {warehouseItem.Unit}, Ціна за одиницю: {warehouseItem.UnitPrice}, Кількість: {warehouseItem.Quantity}, Дата останнього завезення: {warehouseItem.LastDeliveryDate}");

            REporting reporting = new REporting();
            reporting.RegisterIncoming(warehouseItem); 

            reporting.RegisterOutgoing("Smartphone", 3); 
            reporting.InventoryReport(); 


            USD usd = new USD(50, 75);
            EUR eur = new EUR(100, 0);
            UAH uah = new UAH(200, 50);

            Console.WriteLine("\nДемонстрація валют:");
            Console.WriteLine("USD:");
            usd.Display(); 

            Console.WriteLine("EUR:");
            eur.Display(); 

            Console.WriteLine("UAH:");
            uah.Display(); 
        }
    }
}
