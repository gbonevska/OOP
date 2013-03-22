using System;

namespace MathShapes
{
    class TestMathShapes
    {
        static void Main()
        {
            AShape[] figures = new AShape[]
		    {
			    new Triangle(2.2, 3.2),
			    new Triangle(5.3, 6.2),
			    new Rectangle(10, 5),
			    new Rectangle(5, 5),
			    new Cirlce(8),
		    };
            foreach (var f in figures)
            {
                Console.Write(f + " ");
                Console.WriteLine("Surface = {0:0.00}", f.CalculateSurface());
            }
        }
    }
}
