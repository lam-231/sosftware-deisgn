using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTMLLibrary
{
    public class CompactRenderer : LightRendererBase
    {
        protected override void StartElement(StringBuilder sb, LightElementNode element)
        {
            var classAttribute = element.CssClasses.Count > 0
                ? $" class=\"{string.Join(" ", element.CssClasses)}\""
                : "";

            if (element.ClosingType == ClosingType.Single)
            {
                sb.Append($"<{element.TagName}{classAttribute}/>");
            }
            else
            {
                sb.Append($"<{element.TagName}{classAttribute}>");
            }
        }

        protected override void RenderContent(StringBuilder sb, LightElementNode element)
        {
            foreach (var child in element.Children)
            {
                sb.Append(child.OuterHTML);
            }
        }

        protected override void EndElement(StringBuilder sb, LightElementNode element)
        {
            if (element.ClosingType == ClosingType.Pair)
            {
                sb.Append($"</{element.TagName}>");
            }
        }
    }
}
