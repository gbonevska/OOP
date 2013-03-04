using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenetricsTest
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(5);
            for (int i = 0; i < 5; i++)
            {
                list.AddElement(i);
            }
            Console.WriteLine("Add elements\n");
            Console.WriteLine(list.ToString());

            Console.WriteLine("Insert element by index:\n");
            list.InsertByIndex(7, 6);
            Console.WriteLine(list.ToString());

            Console.WriteLine("Find element by value:\n");
            int indexElement = list.FindElementByValue(3);
            Console.WriteLine("element with value 3 has index " + indexElement);

            Console.WriteLine("Find minimun element:\n");
            int minElement = list.Min();
            Console.WriteLine("the minimum element is " + minElement);

            Console.WriteLine("Find maximum element:\n");
            int maxElement = list.Max();
            Console.WriteLine("the maximum element is " + maxElement);


        }
    }
}
