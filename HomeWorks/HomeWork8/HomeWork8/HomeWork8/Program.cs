using System;
using System.Collections.Generic;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.WriteLine("Enter data for shapes 10 times. It should be name of the shape (like circle and square) " +
                              "and a number (like radius or side).");
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter the name for your Circle: ");
                    string circleName = Console.ReadLine();
                    Console.WriteLine("Enter the radius for your Circle: ");
                    double circleRadius = Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Circle(circleName, circleRadius));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format!");
                Console.ReadKey();
            }

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter the name for your Square: ");
                    string squareName = Console.ReadLine();
                    Console.WriteLine("Enter the side for your Square: ");
                    double squareSide = Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Square(squareName, squareSide));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format!");
                Console.ReadKey();
            }

            //=======

            foreach (var sh in shapes)
            {
                sh.Print();
            }

            //=======

            var maxPerim = shapes[0];
            foreach (var sh in shapes)
            {
                if (sh.Perimeter() >= maxPerim.Perimeter())
                {
                    maxPerim = sh;
                }
            }
            Console.WriteLine($"Max perimeter is {maxPerim.Perimeter()} and this is {maxPerim.Name} shape\n");

            //=======

            shapes.Sort();

            //=======

            Console.WriteLine("This is the full list of shapes below: ");
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }

            Console.ReadKey();
        }
    }
}
