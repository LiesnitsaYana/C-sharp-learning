using System;


public class TaskB
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a month number: ");
        int monthNumberFromUser = Convert.ToInt32(Console.ReadLine());
        MonthInfoByNumber(monthNumberFromUser);

    }

    public static void MonthInfoByNumber(int monthNumber)
    { 
        switch (monthNumber)
        {
            case 1:
                Console.Write("This is January. This month has 31 days. \n");
                break;
            case 3:
                Console.Write("This is March. This month has 31 days. \n");
                break;
            case 5:
                Console.Write("This is May. This month has 31 days. \n");
                break;
            case 7:
                Console.Write("This is July. This month has 31 days. \n");
                break;
            case 8:
                Console.Write("This is August. This month has 31 days. \n");
                break;
            case 10:
                Console.Write("This is October. This month has 31 days. \n");
                break;
            case 12:
                Console.Write("This is January. This month has 31 days. \n");
                break;
            case 2:
                Console.Write("This is February. This month has 28 days. When year is leap one, February has 29 days.\n");
                break;
            case 4:
                Console.Write("This is April. This month has 30 days. \n");
                break;
            case 6:
                Console.Write("This is June. This month has 30 days. \n");
                break;
            case 9:
                Console.Write("This is September. This month has 30 days. \n");
                break;
            case 11:
                Console.Write("This is November. This month has 30 days. \n");
                break;
            default:
                Console.Write("invalid Month number.\nPlease try again ....\n");
                break;
        }

        Console.ReadKey();
    }
}
