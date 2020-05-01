using System;

namespace HomeWork8
{
    class Square : Shape, IComparable
    {
        private double _side;

        public double Side
        {
            get { return _side; }
            set { _side = value; }
        }

        public Square(string name, double _side) : base(name)
        {
            Side = _side;
        }

        public override double Area()
        {
            double area = _side * _side;
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = 4 * _side;
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
