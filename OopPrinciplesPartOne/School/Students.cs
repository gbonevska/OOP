using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public class Students : People
    {
        // inherite firstName, lastName and comment fields by base class People
        int studentId = 0;

        //properties
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        // methods
        public override string GetName()
        {
            return "student " + this.FirstName + this.LastName;
        }

        //constructors
        public Students(string firstName, string lastName, int studentId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.studentId = studentId;
        }

    }
}
