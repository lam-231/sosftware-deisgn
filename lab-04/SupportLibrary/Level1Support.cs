using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary
{
    public class Level1Support : SupportHandler
    {
        protected override bool AskUser()
        {
            Console.WriteLine("У вас питання про баланс, тарифи або пiдключення послуг? (1 - так, 0 - нi)");
            string? input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Рiвень 1 пiдтримки: загальнi запитання.");
                return true;
            }
            return false;
        }
    }
}
