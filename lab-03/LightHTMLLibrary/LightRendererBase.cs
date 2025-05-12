using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTMLLibrary
{
    public abstract class LightRendererBase
    {
        public string Render(LightElementNode node)
        {
            var sb = new StringBuilder();
            StartElement(sb, node);
            RenderContent(sb, node);
            EndElement(sb, node);
            return sb.ToString();
        }

        protected virtual void StartElement(StringBuilder sb, LightElementNode node)
        {
            sb.Append($"<{node.TagName}>");
        }

        protected virtual void RenderContent(StringBuilder sb, LightElementNode node)
        {
            foreach (var child in node.Children)
            {
                sb.Append(child.ToString());
            }
        }

        protected virtual void EndElement(StringBuilder sb, LightElementNode node)
        {
            sb.Append($"</{node.TagName}>");
        }
    }
}
