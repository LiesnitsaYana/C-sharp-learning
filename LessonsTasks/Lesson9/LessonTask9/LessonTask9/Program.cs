using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {22, 11, -33, 44, -55, -66, 76, 87, 98, 101 };
            //=====
            int min = numbers.Min();
            Console.WriteLine("Min value in our collection is: {0}", min);

            //=====
            int max = numbers.Max();
            Console.WriteLine("Max value in our collection is: {0}", max);

            //=====
            int sum = numbers.Sum();
            Console.WriteLine("The sum of all elements is: {0}", sum);

            //=====
            double aver = numbers.Average();
            Console.WriteLine("The average of all elements is: {0}", aver);

            //=====

            IEnumerable<int> negativeInts = from num in numbers
                                           where num < 0
                                           select num;

            Console.Write("Negative values in our collection are: ");
            foreach (int i in negativeInts)
                Console.Write("{0}  ", i);

            Console.WriteLine(" ");

            //=====
            IEnumerable<int> positiveInts = from num in numbers
                                           where num > 0
                                           select num;

            Console.Write("Positive values in our collection are: ");
            foreach (int i in positiveInts)
                Console.Write("{0}  ", i);

            Console.WriteLine(" ");

            //=====
            var query = numbers.Where(num => num < aver).Max();
            Console.WriteLine("The first number which is larger than the average of all elements is: {0}", query);
            
            //=====
            IEnumerable<int> sortedList = numbers.OrderBy(num => num);
            Console.Write("Sorted list of numbers is: ");

            foreach (int i in sortedList)
            {
                Console.Write("{0}  ", i);
            }

            Console.ReadKey();
        }
    }
}
