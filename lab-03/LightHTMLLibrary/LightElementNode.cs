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
        private Dictionary<string, List<EventListener>> _eventListeners = new();

        public int ChildrenCount => Children.Count;

        public LightElementNode(string tagName, DisplayType displayType, ClosingType closingType)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
        }

        public void AddClass(string className) => CssClasses.Add(className);
        public void AddChild(LightNode child) => Children.Add(child);

        public void AddEventListener(string eventType, Action<LightElementNode, LightEventArgs> handler)
        {
            if (!_eventListeners.ContainsKey(eventType))
            {
                _eventListeners[eventType] = new List<EventListener>();
            }
            _eventListeners[eventType].Add(new EventListener(eventType, handler));
        }

        public void RemoveEventListener(string eventType, Action<LightElementNode, LightEventArgs> handler)
        {
            if (_eventListeners.ContainsKey(eventType))
            {
                var listenerToRemove = _eventListeners[eventType]
                    .FirstOrDefault(l => l.Handler == handler);
                if (listenerToRemove != null)
                {
                    _eventListeners[eventType].Remove(listenerToRemove);
                }
            }
        }

        public void TriggerEvent(string eventType, LightEventArgs args)
        {
            if (_eventListeners.ContainsKey(eventType))
            {
                foreach (var listener in _eventListeners[eventType])
                {
                    listener.Handler(this, args);
                }
            }
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
    }
}
