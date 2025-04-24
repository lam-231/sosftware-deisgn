using LightHTMLLibrary;

namespace LightHTMLApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var button = new LightElementNode("button", DisplayType.Inline, ClosingType.Pair);
            button.AddChild(new LightTextNode("Click me"));

            button.AddEventListener("click", () => {
                Console.WriteLine("Button was clicked!");
            });

            button.AddEventListener("mouseover", () => {
                Console.WriteLine("Mouse over button!");
            });

            Console.WriteLine("Triggering events:");
            button.TriggerEvent("mouseover");
            button.TriggerEvent("click");

            Console.WriteLine("\nHTML structure:");
            Console.WriteLine(button.OuterHTML);
        }
    }
}
