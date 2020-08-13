using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Triangle : Shape
    {
        public override double CalculateSurface()
        {
            return width * height / 2;
        }

        public Triangle(double width, double height) : base(width,height)
        {
        }
    }
}
