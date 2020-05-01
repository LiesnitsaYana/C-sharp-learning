using System;
using System.Collections.Generic;

namespace LessonTask10_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle(new Point(6, 7), new Point(5, 3), new Point(8, 5)));
            triangles.Add(new Triangle(new Point(1, 2), new Point(-5, -4), new Point(2, 7)));
            triangles.Add(new Triangle(new Point(0, 1), new Point(2, 0), new Point(1, 1)));

            foreach (var triangle in triangles)
            {
                triangle.Print();
            }

            Console.ReadKey();
        }
    }
}
