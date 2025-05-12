using System;
using RPGLibrary;

class Program
{
    static void Main(string[] args)
    {
        IHero warrior = new Warrior();
        IHero mage = new Mage();
        IHero palladin = new Palladin();

        warrior = new Sword(warrior);
        warrior = new Armor(warrior);
        warrior = new Amulet(warrior); 

        mage = new Amulet(mage);
        mage = new Amulet(mage); 

        palladin = new Sword(palladin);
        palladin = new UnbeliveableShit(palladin); 

        PrintHero(warrior);
        PrintHero(mage);
        PrintHero(palladin);
    }

    static void PrintHero(IHero hero)
    {
        Console.WriteLine($"{hero.GetDescription()} | Power: {hero.GetPower()}");
    }
}
