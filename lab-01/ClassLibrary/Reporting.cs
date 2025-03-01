using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class REporting
    {
        private List<Warehouse> _warehouseItems = new List<Warehouse>();

        public void RegisterIncoming(Warehouse item)
        {
            _warehouseItems.Add(item);
            Console.WriteLine($"Додано товар: {item.ProductName}, кількість: {item.Quantity}");
        }

        public void RegisterOutgoing(string productName, int quantity)
        {
            var item = _warehouseItems.Find(x => x.ProductName == productName);
            if (item != null && item.Quantity >= quantity)
            {
                item.UpdateQuantity(item.Quantity - quantity);
                Console.WriteLine($"Відвантажено товар: {productName}, кількість: {quantity}");
            }
            else
            {
                throw new InvalidOperationException("Недостатньо товару на складі.");
            }
        }

        public void InventoryReport()
        {
            Console.WriteLine("Звіт по інвентаризації:");
            foreach (var item in _warehouseItems)
            {
                Console.WriteLine($"{item.ProductName}: {item.Quantity} {item.Unit}");
            }
        }

        public void SaveReportToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Звіт по інвентаризації:");
                foreach (var item in _warehouseItems)
                {
                    writer.WriteLine($"{item.ProductName}: {item.Quantity} {item.Unit}");
                }
            }
            Console.WriteLine($"Звіт збережено у файл: {filePath}");
        }
    }
}
