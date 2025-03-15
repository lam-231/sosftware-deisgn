namespace ClassLibraryCharacters
{
    public class Character
    {
        public string Name { get; }
        public double Height { get; set; }
        public string BodyType { get; set; }
        public string Beard { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get;  set; }
        public string Clothing { get;  set; }
        public List<string> Inventory { get; } = new();
        public List<string> SpecialActions { get; } = new();

        public Character(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"{Name}:\n Height: {Height}m;\n" +
                $" BodyType: {BodyType};\n" +
                $" Beard: {Beard};\n" +
                $" HairColor: {HairColor};\n" +
                $" EyeColor: {EyeColor};\n" +
                $" Clothing: {Clothing}");
            Console.WriteLine(" Inventory: " + string.Join(", ", Inventory));
            Console.WriteLine(" Special Actions: " + string.Join(", ", SpecialActions));
            Console.WriteLine();
        }
    }
}
