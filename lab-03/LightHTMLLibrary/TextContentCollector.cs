using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTMLLibrary
{
    public class TextContentCollector : ILightNodeVisitor
    {
        public void VisitElement(LightElementNode element)
        {
            Console.WriteLine($"<{element.TagName}>");
        }

        public void VisitText(LightTextNode text)
        {
            Console.WriteLine(text.Text);
        }
    }
}
