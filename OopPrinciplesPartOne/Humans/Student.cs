using System;
using System.Collections.Generic;
using System.Linq;


namespace Humans
{
    public class Student : Human
    {
        //fields
        private float grade;

        //properties
        public float Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        //methods
        public override string GetName()
        {
            return "Student: " + this.FirstName + " " + this.LastName;
        }

        public string PrintStudent()
        {
            return GetName() + " grade = " + Grade;
        }

        // flagSort = 1 -> ascending, 2 = descending
        public static IEnumerable<Student> Sorting(List<Student> students, int flagSort)
        {
            IEnumerable<Student> sortStudents = new List<Student>();
            if (flagSort == 1)
            {
                sortStudents =
                       from student in students
                    orderby student.grade ascending 
                     select student; 
            }
            if (flagSort == 2)
            {
                sortStudents =
                      from student in students
                    orderby student.grade descending
                     select student;
            }
            return sortStudents;
        }

        //constructors
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = 0.0f;
        }

        public Student(string firstName, string lastName, float grade)
            : this(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
