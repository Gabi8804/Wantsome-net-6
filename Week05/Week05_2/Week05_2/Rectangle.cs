using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    
    class Rectangle : Shape
    {
        public override double CalculateSurface()
        {
            return width * height;
        }

        public Rectangle(double width, double height) : base(width, height)
        {
        }
    }
}
