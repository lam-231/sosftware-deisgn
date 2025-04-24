using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTMLLibrary
{
    public class LightEventArgs
    {
        public string EventType { get; }
        public object? Data { get; }

        public LightEventArgs(string eventType, object? data = null)
        {
            EventType = eventType;
            Data = data;
        }
    }
}
