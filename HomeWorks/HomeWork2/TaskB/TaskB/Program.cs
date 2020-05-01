using System;
using System.Linq;

namespace TaskB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int enteredNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int enteredNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int enteredNumber3 = Convert.ToInt32(Console.ReadLine());
            int[] arrayOfNumbers = { enteredNumber1, enteredNumber2, enteredNumber3 };
            Console.WriteLine("Max number is {0} and min number is {1}", 
                CheckingMaxNumbers(arrayOfNumbers), CheckingMinNumbers(arrayOfNumbers));
            Console.ReadKey();
        }

        public static int CheckingMaxNumbers(int[] array)
        {
            int max = array.Max();
            return max;
        }

        public static int CheckingMinNumbers(int[] array)
        {
            int min = array.Min();
            return min;
        }
    }
}
