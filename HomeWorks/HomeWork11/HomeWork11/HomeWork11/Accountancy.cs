using System;
using System.Linq;

namespace HomeWork11
{
    public class Accountancy : Student
    {
        public void PayingFellowship(int markAdded)
        {
            marks.Add(markAdded);
            double average = marks.Average();
            if (average >= 71)
            {
                Console.WriteLine($"ACCOUNTMENT: Good news! This student will have the scholarship. " +
                                  $"The average of all her marks is {average}.");
            }
            else
            {
                Console.WriteLine($"ACCOUNTMENT: Unfortunately this student will not have the scholarship. " +
                                  $"The average of all her marks is {average}.");
            }
        }
    }
}
