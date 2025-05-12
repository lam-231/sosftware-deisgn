using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTechFactory; 

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Device> devices = new List<Device>
        {
            Factory.CreateDevice("Laptop", "IProne"),
            Factory.CreateDevice("Netbook", "Kiaomi"),
            Factory.CreateDevice("EBook", "Balaxy"),
            Factory.CreateDevice("Smartphone", "IProne")
        };

            foreach (var device in devices)
            {
                device.ShowInfo();
            }
        }
    }
}
