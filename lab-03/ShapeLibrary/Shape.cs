using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        protected IRender _renderer;

        protected Shape(IRender renderer)
        {
            _renderer = renderer;
        }

        public abstract void Draw();
    }
}
