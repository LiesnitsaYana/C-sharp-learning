using System;

namespace Lesson2Tasks
{
    class Program
    {
        static void Main(string[] args)
        { //Task 1)

            //Console.WriteLine("Enter first number: ");
            //int startPointRange = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter first number: ");
            //int endPointRange = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter first number: ");
            //int divider = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("In a range there are {0} numbers wich could be divided by '3'.",
               // DivideCounter(startPointRange, endPointRange, divider));
            //Console.ReadKey();

            // Task 2)
            //Console.WriteLine("Enter any chars: ");
            //string randomChars = Convert.ToString(Console.ReadLine()); ;
            //TakeEverySecondChar(randomChars);
            //Console.WriteLine("Every second char: {0}", TakeEverySecondChar(randomChars));
            //Console.ReadKey();

            //Task 4)
            CheckingNumbers();

        }
        //For task 1)
        static int DivideCounter(int startPoint, int endPoint, int divider)
        {
            int counter = 0;
            for (int i = startPoint; i <= endPoint; i++)
            {
                if(i % 3 == 0)
                {
                    counter++;
                }
            }
            return counter;
        }


        //For task 2)
        static string TakeEverySecondChar(string inputed)
        {
            string final = "";
            int i = 0;
            foreach (char a in inputed.ToCharArray())
            {
                if (i % 2 != 0)
                    final += a;
                i++;
            }
            return final;
        }

        //For task 4)
        static void CheckingNumbers()
        {
            double sum = 0;
            double inputed = 0;
            int counter = 0;
            while (inputed >= 0)
            {
                Console.WriteLine("Enter a number: ");
                inputed = Convert.ToDouble(Console.ReadLine());
                sum += inputed;
                counter++;
                
            }
            counter --;
            sum -= inputed;
            double everage = sum / counter;
            Console.WriteLine("Average is: {0}", everage);
            Console.ReadKey();
        }

    }
}
