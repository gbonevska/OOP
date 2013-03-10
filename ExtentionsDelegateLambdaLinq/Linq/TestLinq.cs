using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class TestLinq
    {
       static void Main()
        {
           //input data for tests
            Student[] testStudents = { new Student("Ivana", "Ivanova", 21),
                                       new Student("Ivan", "Atanasov", 20),
                                       new Student("Yana", "Zengova", 26),
                                       new Student("Pencho", "Kratunkov", 23),
                                       new Student("Albena", "Petrova", 24),
                                       new Student("Ivan", "Ivanov", 21),
                                      
                                     };
           
           // 03
           Console.WriteLine("Test for task 03 finds students first names are before last name alfabetically :");
           Console.WriteLine("-------------------------------------------------");  
           StudentsName.FirstNameBeforeLastAlfabetically(testStudents);
           

           // 04
           Console.WriteLine();
           Console.WriteLine("Test for task 04. Finds the first name and last name of all students with age between 18 and 24:");
           Console.WriteLine("-------------------------------------------------");
           StudentsName.FindStudentsByAge(testStudents);

           // 05
           Console.WriteLine();
           Console.WriteLine("Test for task 05. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students "
                            + "by first name and last name in descending order.:");
           Console.WriteLine("-------------------------------------------------");
           
           Console.WriteLine();
           Console.WriteLine("Using Extension methods:");
           Console.WriteLine("-------------------------------------------------");
           OrderByAndThanBy.DescOrderByAndThenBy(testStudents);

           Console.WriteLine();
           Console.WriteLine("Using LINQ:");
           Console.WriteLine("-------------------------------------------------");
           OrderByAndThanBy.DescOrderByAndThenByLinq(testStudents);

           // 06
           int[] numbers = new int[100];
           for (int i = 0; i < numbers.Length; i++)
           {
               numbers[i] = i;
           }

           Console.WriteLine();
           Console.WriteLine("Test for task 06. ");
           Console.WriteLine("With built-in extention method and lambda:");
           Console.WriteLine("-------------------------------------------------");
           IntsDivisibleBy7And3.DivisibleBy21Lambda(numbers);
           
           Console.WriteLine();
           Console.WriteLine("Using LINQ:");
           Console.WriteLine("-------------------------------------------------");
           IntsDivisibleBy7And3.DivisibleBy21Linq(numbers);
        }
    }
}
