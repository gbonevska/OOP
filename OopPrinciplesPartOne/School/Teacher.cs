using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
      public class Teacher : People
  {
    // inherite firstName, lastName and comment fields by base class People
    // fields
    private Discipline[] disciplines = new Discipline[5];
 
    // methods
    public override string GetName()
	  {
		   return "teacher " + this.FirstName + this.LastName;
	  }

    //constructors
    public Teacher(string firstName, string lastName)
    {
      this.FirstName = firstName;
      this.LastName = lastName;
    }
    
    public Teacher(string firstName, string lastName, params Discipline[] disciplines )
       : this(firstName, lastName)
    {
        for (int i = 0; i <= disciplines.Length; i++)
      {
          this.disciplines[i] = disciplines[i];
      }
    }
    
  }
  
}
