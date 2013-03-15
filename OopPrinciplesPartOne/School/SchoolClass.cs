using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class SchoolClass
    {
        //fields
        private Teacher[] teachers = new Teacher[20];
        private int classId;
        private string comment;

        //properties
        public Teacher[] Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }
        public int ClassId
        {
            get { return classId; }
            set { classId = value; }
        }
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        //constructions
        public SchoolClass(int classId, params Teacher[] teachers )
        {
            this.classId = classId;
            for (int i = 0; i < teachers.Length; i++)
			{
                this.teachers[i] = teachers[i];
			}
        }
    }
}
