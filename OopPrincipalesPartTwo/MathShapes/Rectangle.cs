using System;

namespace MathShapes
{
    class Rectangle : AShape
    {
        // methods
        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }

        // constructor
        public Rectangle(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

    }
}
