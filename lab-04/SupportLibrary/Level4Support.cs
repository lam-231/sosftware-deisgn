using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary 
{
    public class Level4Support : SupportHandler
    {
        protected override bool AskUser()
        {
            Console.WriteLine("Ви розробник або партнер i потребуєте технiчної iнтеграцiї? (1 - так, 0 - нi)");
            string? input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Рiвень 4 пiдтримки: технiчна пiдтримка для iнтеграцiй.");
                return true;
            }
            return false;
        }
    }
}
