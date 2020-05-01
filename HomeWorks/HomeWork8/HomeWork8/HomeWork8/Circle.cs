using System;

namespace HomeWork8
{
    class Circle : Shape, IComparable
    {
        private double _radius;
        private double PI = 3.14;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Circle(string name, double _radius) : base(name)
        {
            Radius = _radius;
        }

        public override double Area()
        {
            double area = PI * _radius * _radius;
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = 2 * PI * _radius;
            return perimeter;
        }

        public override void Print()
        {
            Console.WriteLine("This shape is " + Name + "\nIt's area is: " + Area() + "\nIt's perimeter is: " + Perimeter() + "\n");
        }

        public int CompareTo(object obj)
        {
            Square square = obj as Square;
            Circle circle = obj as Circle;
            if (square != null)
                return Area().CompareTo(square.Area());
            else if (circle != null)
                return Area().CompareTo(circle.Area());
            else throw new ArgumentException("There is no shape!");
        }

        public override string ToString()
        {
            return "This shape is " + Name + ". It's area is: " + Area() + ". It's perimeter is: " + Perimeter() + "\n";
        }
    }
}
