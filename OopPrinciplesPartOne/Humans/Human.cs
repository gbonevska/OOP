using System;
using System.Collections.Generic;
using System.Linq;

namespace Humans
{
    public abstract class Human
    {
        //fields
        private string firstName; 
        private string lastName;

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

        // Abstract methods --> should be implemented in the child classes
        public abstract string GetName();

        // Non-abstract method
        public override string ToString()
        {
            return "I am " + this.GetName();
        }

        // flagSort = 1 -> ascending, 2 = descending
        public static IEnumerable<Human> Sorting(List<Human> humans, int flagSort)
        {
            IEnumerable<Human> sortHumans = new List<Human>();
            if (flagSort == 1)
            {
                sortHumans =
                       from human in humans
                    orderby human.firstName, human.lastName ascending
                     select human;
            }
            if (flagSort == 2)
            {
                sortHumans =
                       from human in humans
                    orderby human.firstName, human.lastName descending
                     select human;
            }
            return sortHumans;
        }
 
    }
}
