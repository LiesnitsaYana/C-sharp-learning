using System;

namespace TaskC
{
    class Program
    {
        static void Main(string[] args)
        {

            CulculatingIntegerNumbers();

        }

        public static void CulculatingIntegerNumbers()
        {
            int number = 0;
            int sumOfNumbers = 0;
            int productOfNumbers = 1;
            bool isNumberNegative = false;

            Console.WriteLine("Enter 10 numbers (both: positive and negative): ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Entered number {0} is ", i + 1);
                number = Convert.ToInt32(Console.ReadLine());
                if (i < 5 && number < 0)
                    isNumberNegative = true;
                if (i < 5) sumOfNumbers += number;
                if (i >= 5) productOfNumbers *= number;
            }
            Console.WriteLine(isNumberNegative ? "Sum of the first 5 elements is {0}" :
                "Product of the last 5 elements is {1}", sumOfNumbers, productOfNumbers);

            Console.ReadKey();
        }
    }
}
