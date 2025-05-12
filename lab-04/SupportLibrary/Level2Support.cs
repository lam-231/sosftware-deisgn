using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary
{
    public class Level2Support : SupportHandler
    {
        protected override bool AskUser()
        {
            Console.WriteLine("Ви маєте проблеми з мережею або мобiльним iнтернетом? (1 - так, 0 - нi)");
            string? input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Рiвень 2 пiдтримки: мережевi питання.");
                return true;
            }
            return false;
        }
    }
}
