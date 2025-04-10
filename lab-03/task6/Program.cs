using LightHTMLLibrary;
using System.Diagnostics;

namespace LightHTMLApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";

            using HttpClient client = new();
            string text = await client.GetStringAsync(url);

            string[] lines = text.Split('\n');

            var root = new LightElementNode("div", DisplayType.Block, ClosingType.Pair);

            long beforeMemory = GC.GetTotalMemory(true);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].TrimEnd('\r');

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string tag;
                if (i == 0)
                    tag = "h1";
                else if (line.Length < 20)
                    tag = "h2";
                else if (char.IsWhiteSpace(line[0]))
                    tag = "blockquote";
                else
                    tag = "p";

                var element = TagFactory.GetElement(tag);
                element.AddChild(new LightTextNode(line));
                root.AddChild(element);
            }

            long afterMemory = GC.GetTotalMemory(true);

            Console.WriteLine("Outer HTML (першi 1000 символiв):");
            Console.WriteLine(root.OuterHTML[..Math.Min(root.OuterHTML.Length, 1000)] + "...");
            Console.WriteLine();
            Console.WriteLine($"Кiлькiсть елементiв у деревi: {root.Children.Count}");
            Console.WriteLine($"Використано памʼятi: {(afterMemory - beforeMemory) / 1024.0:F2} KB");
        }
    }
}
