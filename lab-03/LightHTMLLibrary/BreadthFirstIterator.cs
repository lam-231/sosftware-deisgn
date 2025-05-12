using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTMLLibrary
{
    class BreadthFirstIterator : ILightNodeIterator
    {
        private readonly Queue<LightNode> _queue = new();
        private readonly LightNode _root;

        public BreadthFirstIterator(LightNode root)
        {
            _root = root;
            Reset();
        }

        public bool HasNext() => _queue.Count > 0;

        public LightNode Next()
        {
            var current = _queue.Dequeue();
            if (current is LightElementNode element)
            {
                foreach (var child in element.Children)
                {
                    _queue.Enqueue(child);
                }
            }
            return current;
        }

        public void Reset()
        {
            _queue.Clear();
            _queue.Enqueue(_root);
        }
    }
}
