using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTMLLibrary
{
    public class PrettyRenderer : LightRendererBase
    {
        protected override void StartElement(StringBuilder sb, LightElementNode node)
        {
            sb.AppendLine($"<{node.TagName}>");
        }

        protected override void RenderContent(StringBuilder sb, LightElementNode node)
        {
            foreach (var child in node.Children)
            {
                sb.AppendLine("  " + child.ToString());
            }
        }

        protected override void EndElement(StringBuilder sb, LightElementNode node)
        {
            sb.AppendLine($"</{node.TagName}>");
        }
    }
}
