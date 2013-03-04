using System;
using System.Collections.Generic;
using System.IO;

namespace DefiningClassPartTwo
{
    static class PathStorage
    {
        const string InputOutputFile = @"../../PathsPoints.txt";

        public static void SavePathPoints(Path listOfPoints)
        {
            StreamWriter writer = new StreamWriter(InputOutputFile);
            using (writer)
            {
                writer.WriteLine(listOfPoints.ToString());
            }
        }

        public static Path LoadPathPoints()
        {
            Path loadedPaths = new Path();
            string[] loadedPathsFromFile, points;
            string paths, line;
            StreamReader reader = new StreamReader(InputOutputFile);
            Point3D point = new Point3D(0,0,0);
            using(reader)
            {
                line = reader.ReadLine();
                while (line != string.Empty)
                {
                    loadedPathsFromFile = line.Split('\n');
                    
                    foreach (var path in loadedPathsFromFile)
                    {
                        paths = path.Substring(1, path.Length-2);
                        points = paths.Split(',');
                        point.X = int.Parse(points[0]);
                        point.Y = int.Parse(points[1]);
                        point.Z = int.Parse(points[2]);
                        loadedPaths.AddListOfPoints(point);
                    }
                    line = reader.ReadLine();
                }
                
            }
            return loadedPaths;
        }
    }
}
