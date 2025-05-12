using System;
using ShapeLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IRender vector = new VectorRenderer();
            IRender raster = new RasterRenderer();

            Shape circle = new Circle(vector);
            Shape square = new Square(raster);
            Shape triangle = new Triangle(vector);

            circle.Draw();    
            square.Draw();    
            triangle.Draw();  
        }
    }
}
