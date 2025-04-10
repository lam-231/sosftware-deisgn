using LightHTMLLibrary;

namespace LightHTMLApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var div = new LightElementNode("div", DisplayType.Block, ClosingType.Pair);
            div.AddClass("container");

            var h1 = new LightElementNode("h1", DisplayType.Block, ClosingType.Pair);
            h1.AddClass("main-title");
            h1.AddChild(new LightTextNode("LightHTML!"));

            var p = new LightElementNode("p", DisplayType.Block, ClosingType.Pair);
            p.AddChild(new LightTextNode("абзац тексту в власній HTML-мові."));

            div.AddChild(h1);
            div.AddChild(p);

            Console.WriteLine("OUTER HTML:");
            Console.WriteLine(div.OuterHTML);
            Console.WriteLine();

            Console.WriteLine("INNER HTML:");
            Console.WriteLine(div.InnerHTML);
        }
    }
}
