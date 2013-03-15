using System;
using System.Linq;

namespace school
{
    public abstract class People : ICommentate
    {
        // fields
        private string firstName; 
        private string lastName;

        // Interface field
        private string comment;

       // properties
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

        // Inverface properties
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }


        // Abstract methods --> should be implemented in the child classes
        public abstract string GetName();

        // Non-abstract method
        public override string ToString()
        {
            return "I am " + this.GetName();
        }
    }
}
