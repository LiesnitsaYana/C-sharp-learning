using System;

namespace HomeWork8
{
    abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public virtual double Area()
        {
            double area = 0;
            return area;
        }

        public virtual double Perimeter()
        {
            double perimeter = 0;
            return perimeter;
        }

        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
