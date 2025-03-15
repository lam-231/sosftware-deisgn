using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTechFactory
{
    public abstract class Device
    {
        public string Brand { get; }
        public string Model { get; }

        protected Device(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public abstract void ShowInfo();
    }
}
