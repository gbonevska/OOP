using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public class Discipline : ICommentate
    {
        //fields
        private string name;
        private int numLectures;
        private int numExercises;
        private string comment;
 
        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NumLectures
        {
            get { return numLectures; }
            set { numLectures = value; }
        }
        public int NumExercises
        {
            get { return numExercises; }
            set { numExercises = value; }
        }
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        //constructors
        public Discipline(string name, int numLectures, int numExercises)
        {
            this.name = name;
            this.numLectures = numLectures;
            this.numExercises = numExercises;
        }

        public Discipline(string name, int numLectures, int numExercises, string comment)
            : this(name, numLectures, numExercises)
        {
            this.comment = comment;
        }
    }
}
