namespace ClassLibraryViruss
{
    public class Viruss : ICloneable
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public List<Viruss> Children { get; set; }

        public Viruss(string name, double weight, int age, string species)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Species = species;
            Children = new List<Viruss>();
        }

        public void AddChild(Viruss child)
        {
            Children.Add(child);
        }

        public object Clone()
        {
            Viruss clone = new Viruss(Name, Weight, Age, Species);
            foreach (var child in Children)
            {
                clone.Children.Add((Viruss)child.Clone());
            }
            return clone;
        }

        public void PrintInfo(string indent = "")
        {
            Console.WriteLine($"{indent}Вірус: {Name}, Вага: {Weight}, Вік: {Age}, Вид: {Species}");
            foreach (var child in Children)
            {
                child.PrintInfo(indent + "  ");
            }
        }
    }
}
