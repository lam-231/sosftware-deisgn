using ClassLibraryCharacters;

public class Program
{
    public static void Main()
    {
        CharacterDirector director = new CharacterDirector();

        Character hero = director.ConstructHero(new HeroBuilder("Торiн Дубогриз"));
        Character enemy = director.ConstructEnemy(new EnemyBuilder("(просто)Трандуiл"));

        hero.Display();
        enemy.Display();
    }
}