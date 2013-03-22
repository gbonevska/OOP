using System;

namespace MathShapes
{
    class Cirlce : AShape
    {
       // methods
        public override double CalculateSurface()
        {
            return Math.PI * this.Height * this.Height;
        }

        // constuctor
        public Cirlce(double width)
        {
            this.Width = width;
            this.Height = this.Width;
        }

    }
}
