using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassPartTwo
{
    public static class Point
    {
        /* http://www.calculatorsoup.com/calculators/geometry-solids/distance-two-points.php */
        public static double calcDistnaceBetweenTwoPoints3D(Point3D pointOne, Point3D pointTwo)
        {
            double distance;
            distance = Math.Sqrt(Math.Pow(pointTwo.X - pointOne.X, 2)
                                 + Math.Pow(pointTwo.Y - pointOne.Y, 2)
                                 + Math.Pow(pointTwo.Z - pointOne.Z, 2)
                                );
            return distance;
        }
        static void Main()
        {
            Point3D point = new Point3D(5, -2, 4);
            Console.WriteLine( Point3D.ZeroPoint.ToString());
            Console.WriteLine( point.ToString() );
            Console.WriteLine("distance between {0} and {1} is equal to {2}.",
                               Point3D.ZeroPoint.ToString(), point.ToString(), 
                               calcDistnaceBetweenTwoPoints3D(Point3D.ZeroPoint, point)
                             );

            Console.WriteLine("Path of points: \n");
            Point3D pointOne = new Point3D(-1, 2, 4);
            Point3D pointTwo = new Point3D(9, -2, 14);
            Point3D pointThree = new Point3D(0, -2, 6);
            Point3D pointFour = new Point3D(5, 7, -4);
            Point3D pointFive = new Point3D(8, 5, 11);
            Path pointsList = new Path();
            
            pointsList.AddListOfPoints(Point3D.ZeroPoint);
            pointsList.AddListOfPoints(point);
            pointsList.AddListOfPoints(pointOne);
            pointsList.AddListOfPoints(pointTwo);
            pointsList.AddListOfPoints(pointThree);
            pointsList.AddListOfPoints(pointFour);
            pointsList.AddListOfPoints(pointFive);

            Console.WriteLine(pointsList);

            Console.WriteLine("Save path of points: \n");
            PathStorage.SavePathPoints(pointsList);

            Console.WriteLine("Load path of points: \n");
            Path pointLoadedList = new Path();
            pointLoadedList = PathStorage.LoadPathPoints();
            Console.WriteLine(pointLoadedList.ToString());
            
       }
    }
}
