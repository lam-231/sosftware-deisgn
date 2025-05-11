using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTMLLibrary
{
    public class DepthFirstIterator : ILightNodeIterator
    {
        private readonly Stack<LightNode> _stack = new();
        private readonly LightNode _root;

        public DepthFirstIterator(LightNode root)
        {
            _root = root;
            Reset();
        }

        public bool HasNext() => _stack.Count > 0;

        public LightNode Next()
        {
            var current = _stack.Pop();
            if (current is LightElementNode element)
            {
                for (int i = element.Children.Count - 1; i >= 0; i--)
                {
                    _stack.Push(element.Children[i]);
                }
            }
            return current;
        }

        public void Reset()
        {
            _stack.Clear();
            _stack.Push(_root);
        }
    }
}
