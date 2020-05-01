using System;

namespace LessonTask10_Triangle
{
    public struct Point
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void ToString(Point p)
        {
            Console.WriteLine($"Point: {p.X};{p.Y}");
        }
    }
}
