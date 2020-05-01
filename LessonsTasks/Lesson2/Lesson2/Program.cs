using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month;
            Console.WriteLine("Введіть перше число: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((day > 0) && (day < 31) ? "Це і правда день місяця." : "Це не є номером дня місяця.");
            Console.WriteLine("Введіть друге число: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((month > 0) && (month < 12) ? "Це і правда номер місяця." : "Це не є номером місяця.");
            Console.ReadKey();
        }
    }
}
