using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTMLLibrary
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public DisplayType DisplayType { get; set; }
        public ClosingType ClosingType { get; set; }
        public List<string> CssClasses { get; set; } = new List<string>();
        public List<LightNode> Children { get; set; } = new List<LightNode>();

        public int ChildrenCount => Children.Count;
        public ILightNodeIterator GetIterator(bool depthFirst = true)
        {
            return depthFirst
                ? new DepthFirstIterator(this)
                : new BreadthFirstIterator(this);
        }
        public LightElementNode(string tagName, DisplayType displayType, ClosingType closingType)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public override string InnerHTML
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var child in Children)
                {
                    sb.Append(child.OuterHTML);
                }
                return sb.ToString();
            }
        }

        public override string OuterHTML
        {
            get
            {
                var classAttribute = CssClasses.Any() ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
                if (ClosingType == ClosingType.Single)
                {
                    return $"<{TagName}{classAttribute}/>";
                }

                return $"<{TagName}{classAttribute}>{InnerHTML}</{TagName}>";
            }
        }

        public IRenderState RenderState { get; set; } = (IRenderState)new NormalRenderState();

        public string Render()
        {
            return RenderState.Render(this);
        }

        public string DefaultRender()
        {
            var sb = new StringBuilder();
            sb.Append($"<{TagName}>");
            foreach (var child in Children)
            {
                sb.Append(child.ToString());
            }
            sb.Append($"</{TagName}>");
            return sb.ToString();
        }
        public override void Accept(ILightNodeVisitor visitor)
        {
            visitor.VisitElement(this);
            foreach (var child in Children)
            {
                child.Accept(visitor);
            }
        }
    }
}
