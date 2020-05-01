using System;

namespace LessonTask6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("Enter number {0} in the range [{1}...{2}] : ", i, 1, 10);
                    int number = ReadNumberFromUser(1, 10, i);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("The number is not integer!");
                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is not in the range.");
                Console.ReadKey();
            }
        }

        static int ReadNumberFromUser(int start, int end, int i)
        {
            int number = int.Parse(Console.ReadLine());

            if ((number < start) || (number > end))
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
        }
    }
}


