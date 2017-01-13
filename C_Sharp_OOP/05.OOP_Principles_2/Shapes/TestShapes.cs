using System;
using System.Collections.Generic;

namespace Shapes
{
    class TestShapes
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>()
                         {
                             new Rectangle(2,3),
                             new Triangle(4,3),
                             new Square(3)
                         };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name} with width:{shape.Width} and height:{shape.Height} has area of: {shape.CalculateSurface()}");
            }

            
        }
    }
}