using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTMLLibrary
{
    public class EventListener
    {
        public string EventType { get; }
        public Action<LightElementNode, LightEventArgs> Handler { get; }

        public EventListener(string eventType, Action<LightElementNode, LightEventArgs> handler)
        {
            EventType = eventType;
            Handler = handler;
        }
    }
}
