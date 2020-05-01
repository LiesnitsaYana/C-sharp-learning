using System;

namespace HomeWork2_task_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            float number2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            float number3 = float.Parse(Console.ReadLine());
            CheckingNumberRange(number1);
            CheckingNumberRange(number2);
            CheckingNumberRange(number3);


        }
        public static void CheckingNumberRange(float number)
        {
            Console.WriteLine((number >= -5.0 && number <= 5.0) ? 
                $"The number {number} is within the range from -5.0 to 5.0." :
                $"The number {number} is not within the range from -5 to 5.0.");
            Console.ReadKey();
        }
    }
}
