using System;
using System.Linq;
using System.Text;

namespace ExtentionMethods
{
    class TestExtentions
    {
        static void Main()
        {
            Console.WriteLine("Test for task 01 extentions of ToString() :");
            StringBuilder strString = new StringBuilder();
            strString.Append("mesttesthesst");
            StringBuilder strString2 = new StringBuilder();
            strString2 = strString.Substring(4, 4);
            Console.WriteLine("{0} Substring(4, 4) ---> {1} ", strString, strString2);

            Console.WriteLine();
            Console.WriteLine("Test for task 02 IEnumerableExtentions methods :");

            int[] testNumbers = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Sum: " + testNumbers.Sum<int>());
            Console.WriteLine("Product: " + testNumbers.Product<int>());
            Console.WriteLine("Max: " + testNumbers.Max<int>());
            Console.WriteLine("Min: " + testNumbers.Min<int>());
            Console.WriteLine("Count: " + testNumbers.Count<int>());
            Console.WriteLine("Average: " + testNumbers.Avarage<int>());
        }
    }
}
