using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class OrderByAndThanBy
    {

        /* 05. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students 
         * by first name and last name in descending order. Rewrite the same with LINQ. */

        public static void DescOrderByAndThenBy(Student[] studentsNames)
        {
            // Sort the strings first by their length and then alphabetically by passing the identity selector function.
           // use ThenBy<TSource, TKey>(IOrderedEnumerable<TSource>, Func<TSource, TKey>) to perform a secondary ordering of the elements in a sequence.
            
            var query =
                studentsNames.OrderByDescending(student => (student.FirstName))
                .ThenByDescending(student => student.LastName);

            foreach (var student in query)
            {
                Console.WriteLine(student.FirstName + ' ' + student.LastName);
            }
        }


        public static void DescOrderByAndThenByLinq(Student[] studentsNames)
        {
            var query =
                from student in studentsNames
                orderby (student.FirstName + ' ' + student.LastName) descending
                select (new { student.FirstName, student.LastName } );

            foreach (var student in query)
            {
                Console.WriteLine(student.FirstName + ' ' + student.LastName);
            }
        }
    }
}
