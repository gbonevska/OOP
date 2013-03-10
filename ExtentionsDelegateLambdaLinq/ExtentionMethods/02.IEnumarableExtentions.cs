using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    static class IEnumarableExtentions
    {
        /* 02. Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average. */

        public static T Sum<T>(this IEnumerable<T> numbers)
        {
           dynamic sum = 0;
           foreach (var item in numbers)
           {
               sum += (dynamic)item;
           }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> numbers)
        {
            dynamic product = 1;
            foreach (var item in numbers)
            {
                product *= (dynamic)item;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> numbers)
        {
            dynamic min = ReturnByIndex<T>(numbers, 0);

            foreach (var item in numbers)
            {
                if (min > (dynamic)item)
                {
                    min = (dynamic)item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> numbers)
        {
            dynamic max = ReturnByIndex<T>(numbers, 0);

            foreach (var item in numbers)
            {
                if (max < (dynamic)item)
                {
                    max = (dynamic)item;
                }
            }
            return max;
        }

        public static T Count<T>(this IEnumerable<T> numbers)
        {
            dynamic count = 0;
            foreach (var item in numbers)
            {
                count++;
            }
            return count;
        }

        public static T ReturnByIndex<T>(this IEnumerable<T> numbers, int index)
        {
            dynamic count = 0, result = 0;
            
            foreach (var item in numbers)
            {
                if (index == count)
                {
                    result = item;
                    break;
                }
                count++;
            }
            return result;
        }

        public static T Avarage<T>(this IEnumerable<T> numbers)
        {
            dynamic avarage = 0;
            dynamic sum = Sum<T>(numbers);
            dynamic count = Count<T>(numbers);

            if (count != null && sum != null)
            {
                avarage = sum / count;
            }

            return avarage;
        }

    }
}
