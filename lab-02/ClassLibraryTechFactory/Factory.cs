using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTechFactory
{
    public class Factory
    {
        public static Device CreateDevice(string type, string brand)
        {
            type = type.ToLower();
            if (type == "laptop")
                return new Laptop(brand);
            else if (type == "netbook")
                return new Netbook(brand);
            else if (type == "ebook")
                return new EBook(brand);
            else if (type == "smartphone")
                return new Smartphone(brand);
            else
                throw new ArgumentException("Unknown device type");
        }
    }
}
