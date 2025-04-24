using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary
{
    public class SupportApp
    {
        private readonly SupportHandler chain;

        public SupportApp()
        {
            var level1 = new Level1Support();
            var level2 = new Level2Support();
            var level3 = new Level3Support();
            var level4 = new Level4Support();

            level1.SetNext(level2);
            level2.SetNext(level3);
            level3.SetNext(level4);

            chain = level1;
        }

        public void Start()
        {
            bool resolved = false;

            while (!resolved)
            {
                Console.WriteLine("Вiтаємо в системi пiдтримки!\nБудь ласка, дайте вiдповiдi на кiлька питань...\n");

                chain.StartSupport();

                Console.WriteLine("\nБажаєте повторити пошук пiдтримки? (1 - так, 0 - нi)");
                string? retry = Console.ReadLine();
                if (retry != "1")
                {
                    resolved = true;
                }

                Console.Clear();
            }

            Console.WriteLine("Дякуємо за звернення!");
        }
    }
}
