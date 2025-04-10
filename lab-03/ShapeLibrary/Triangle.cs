using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        public Triangle(IRender renderer) : base(renderer) { }

        public override void Draw()
        {
            _renderer.Render("Triangle");
        }
    }
}
