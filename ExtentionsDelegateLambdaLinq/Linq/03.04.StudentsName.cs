using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Linq
{
    public class Student
    {
        //fields
        private string firstName;
        private string lastName;
        private int age;

        //properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //constructors
        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
    }

    public class StudentsName
    {
        /* 03. Write a method that from a given array of students finds all students whose 
         * first name is before its last name alphabetically. Use LINQ query operators.
        */

        public static void FirstNameBeforeLastAlfabetically(Student[] studentsNames)
        {
            var queryFirstBeforeLastNames = 
                from student in studentsNames
                 where string.Compare(student.FirstName, student.LastName) < 0
                select (new { student.FirstName, student.LastName });

            foreach (var student in queryFirstBeforeLastNames)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
           
        } 

        /* 04. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. */
        public static void FindStudentsByAge(Student[] studentsNames)
        {
             var queryStudentsMiddleAge = 
               from student in studentsNames
                 where student.Age > 19 && student.Age < 24
                   select ( new {student.FirstName, student.LastName, student.Age}) ;

             foreach (var student in queryStudentsMiddleAge)
             {
                 Console.WriteLine("{0} {1} is {2} years old.", student.FirstName, student.LastName, student.Age);
             }
        }
    }

}
