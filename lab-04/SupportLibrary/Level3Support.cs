using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary
{
    public class Level3Support : SupportHandler
    {
        protected override bool AskUser()
        {
            Console.WriteLine("У вас несправнiсть iз SIM-картою або пристроєм? (1 - так, 0 - нi)");
            string? input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Рiвень 3 пiдтримки: пристрої та SIM-карти.");
                return true;
            }
            return false;
        }
    }
}
