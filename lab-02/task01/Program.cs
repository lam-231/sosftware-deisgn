using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFabMethod;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISubCreator> creators = new List<ISubCreator>
        {
            new WebSite(),
            new MobileApp(),
            new ManagerCall()
        };

            foreach (var creator in creators)
            {
                Subscription subscription = creator.CreateSubscription();
                Console.WriteLine(subscription);
            }
        }
    }
}
