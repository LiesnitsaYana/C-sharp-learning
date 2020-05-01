using System;

namespace LessonTask10_Triangle
{
    public class Triangle
    {
        private Point vertex1, vertex2, vertex3;

        public Triangle(Point a, Point b, Point c)
        {
            vertex1 = a;
            vertex2 = b;
            vertex3 = c;
        }

        public double Distance(Point a, Point b)
        {
            double distance = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
            return Math.Round(distance, 2);
        }

        public double Perimetr()
        {
            double perimetr = Distance(vertex1,vertex2) + Distance(vertex2, vertex3) 
                                                        + Distance(vertex3, vertex1);
            return perimetr;
        }

        public double Square()
        {
            double halfOfPerimetr = Perimetr() / 2;
            double square = Math.Sqrt(halfOfPerimetr * (halfOfPerimetr - Distance(vertex1, vertex2)) 
                                                     *(halfOfPerimetr - Distance(vertex2, vertex3)) 
                                                     *(halfOfPerimetr - Distance(vertex3, vertex1)));
            return square;
        }

        public void Print()
        {
            Console.WriteLine($"Perimeter = {Perimetr()}, square = {Square()}.");
        }
    }
}
