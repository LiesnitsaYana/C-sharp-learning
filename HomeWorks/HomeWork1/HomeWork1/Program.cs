using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 (a):
            MathOperationsWithSquare();

            //Task 1 (b):
            OperationsWithUserData();

            //Task 1 (c):
            MathOperationWithDouble();

        }

        //For part "a":

        public static int SquareArea(int squareSide)
        {
            int result = Convert.ToInt32(Math.Pow(squareSide, 2));
            return result;
        }

        public static int SquarePerimeter(int squareSide)
        {
            int result = (squareSide * 4);
            return result;
        }

        public static void MathOperationsWithSquare()
        {
            Console.WriteLine("Enter a number: ");
            string dataFromUser = Console.ReadLine();
            int a = Convert.ToInt32(dataFromUser);
            Console.WriteLine("The square area is: {0} and the square perimeter is: {1}", SquareArea(a), SquarePerimeter(a));
            Console.ReadKey();
        }

        //For part "b":

        public static void OperationsWithUserData()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            string userName = Convert.ToString(name);
            Console.WriteLine("How old are you, {0}?", userName);
            string age = Console.ReadLine();
            int userAge = Convert.ToInt32(age);
            Console.WriteLine("So your name is {0} and you are {1} years old.", userName, userAge);
            Console.ReadKey();
        }

        //For part "c":

        public static double LengthCalculationWithDouble(double numberInputed)
        {
            double pi = 3.14;
            double length = (2 * pi * numberInputed);
            return length;
        }

        public static double AreaCalculationWithDouble(double numberInputed)
        {
            double pi = 3.14;
            double b = Convert.ToDouble(Math.Pow(numberInputed, 2));
            double area = (pi * b);
            return area;
        }

        public static double VolumeCalculationWithDouble(double numberInputed)
        {
            double pi = 3.14;
            double b = Convert.ToDouble(Math.Pow(numberInputed, 3));
            double volume = ((4.0/3.0) * pi * b);
            return volume;
        }

        public static void MathOperationWithDouble()
        {
            Console.WriteLine("Enter a number: ");
            string r = Console.ReadLine();
            double doubleNumber = Convert.ToDouble(r);
            Console.WriteLine("The length is: {0}", LengthCalculationWithDouble(doubleNumber));
            Console.WriteLine("The area is: {0}", AreaCalculationWithDouble(doubleNumber));
            Console.WriteLine("The volume is: {0}", VolumeCalculationWithDouble(doubleNumber));
            Console.ReadKey();
        }
    }
}
