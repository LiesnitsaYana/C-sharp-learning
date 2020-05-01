using System;

namespace LessonTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            double intNumber1;
            int intNumber2;
            
            try
            {
                Console.WriteLine("Enter a number: ");
                intNumber1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter a second number: ");
                intNumber2 = Convert.ToInt32(Console.ReadLine());
                double result = intNumber1 / intNumber2;
                Console.WriteLine("Result is: {0}", result);
                Console.ReadKey();
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Divider can't be 0!");
                Console.ReadKey();
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"ERROR: " + ex.Message);
                Console.ReadKey();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"ERROR: " + ex.Message);
                Console.ReadKey();
            }
        }
    }
}
