using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTMLLibrary
{
    public static class TagFactory
    {
        private static readonly Dictionary<string, LightElementNode> _cache = new();

        public static LightElementNode GetElement(string tag)
        {
            if (!_cache.TryGetValue(tag, out var element))
            {
                element = new LightElementNode(tag, DisplayType.Block, ClosingType.Pair);
                _cache[tag] = element;
            }

            return new LightElementNode(
                element.TagName,
                element.DisplayType,
                element.ClosingType
            );
        }
    }
}
