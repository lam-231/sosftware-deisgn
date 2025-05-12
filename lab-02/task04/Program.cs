
using ClassLibraryViruss;

class Program
{
    static void Main()
    {
        Viruss parent = new Viruss("Genadiy", 2.5, 5, "Trojan");
        Viruss child1 = new Viruss("Valeriy", 1.5, 2, "Trojan");
        Viruss child2 = new Viruss("Ole", 1.9, 1, "Trojan");
        Viruss grandchild = new Viruss("Sanya", 0.5, 1, "Trojan");

        child1.AddChild(grandchild);
        parent.AddChild(child1);
        parent.AddChild(child2);

        Viruss clonedParent = (Viruss)parent.Clone();

        Console.WriteLine("Оригінальний вірус:");
        parent.PrintInfo();

        Console.WriteLine("\nКлонований вірус:");
        clonedParent.PrintInfo();
    }
}