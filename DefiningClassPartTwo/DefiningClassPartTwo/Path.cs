using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassPartTwo
{
    class Path
    {
        List<Point3D> listOfPoints = new List<Point3D>();

        public List<Point3D> ListOfPoints
        {
            get { return listOfPoints; }
            set { listOfPoints = value; }
        }

        public void AddListOfPoints(Point3D point)
        {
            this.ListOfPoints.Add(point);
        }

        public override string ToString()
        {
            string result = string.Empty;

            foreach (var path in listOfPoints)
            {
               // result += string.Format("Point3D(x,y,z) = ({0},{1},{2}) \n", path.X, path.Y, path.Z);
                result += string.Format("({0},{1},{2})\n", path.X, path.Y, path.Z);
            }
            
            return result;
        }

    }
}
