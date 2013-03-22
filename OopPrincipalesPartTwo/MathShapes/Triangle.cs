using System;

namespace MathShapes
{
    class Triangle : AShape
    {
        //methods
        public override double CalculateSurface()
        {
            return this.Height * this.Width / 2.0;
        }

        //constructor
        public Triangle(double height, double width)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
