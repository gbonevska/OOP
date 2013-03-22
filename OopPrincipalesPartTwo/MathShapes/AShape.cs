using System;

namespace MathShapes
{
    abstract class AShape
    {
        // fields
        private double width;
        private double height;

        // properties
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        //methods
        public abstract double CalculateSurface();

    }
}
