using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTechFactory
{
    public class Laptop : Device
    {
        public Laptop(string brand) : base(brand, "Laptop") { }
        public override void ShowInfo() => Console.WriteLine($"Brand: {Brand}, Device: {Model}");
    }

    public class Netbook : Device
    {
        public Netbook(string brand) : base(brand, "Netbook") { }
        public override void ShowInfo() => Console.WriteLine($"Brand: {Brand}, Device: {Model}");
    }

    public class EBook : Device
    {
        public EBook(string brand) : base(brand, "EBook") { }
        public override void ShowInfo() => Console.WriteLine($"Brand: {Brand}, Device: {Model}");
    }

    public class Smartphone : Device
    {
        public Smartphone(string brand) : base(brand, "Smartphone") { }
        public override void ShowInfo() => Console.WriteLine($"Brand: {Brand}, Device: {Model}");
    }
}
