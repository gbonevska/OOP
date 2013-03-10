using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class IntsDivisibleBy7And3
    {
        /* 06. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
         * Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
         */

        // with built-in extension
        public static void DivisibleBy21Lambda(int[] numbers)
        {
            var result = numbers.Where(number => (number % 21 == 0 && number != 0)).ToArray();
            
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }

        public static void DivisibleBy21Linq(int[] numbers)
        {
            var query =
                from number in numbers
                where (number % 21 == 0 && number != 0)
                select number;

            foreach (var number in query)
            {
                Console.WriteLine(number);
            }
        }
    }
}
