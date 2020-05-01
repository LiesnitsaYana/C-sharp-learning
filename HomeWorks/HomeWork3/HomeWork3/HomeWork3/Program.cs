using System;

namespace HomeWork3_TaskA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text: ");
            string userInputFromConsole = Convert.ToString(Console.ReadLine()); 
            Console.WriteLine("The number of chars 'a', 'o', 'i', 'e' is: {0}", CountMethod(userInputFromConsole));
            Console.ReadKey();

        }

        public static int CountMethod(string userInput)
        {
            int charsCounter = 0; 

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'a' || userInput[i] == 'o' || userInput[i] == 'i' || userInput[i] == 'e')
                    charsCounter++;
            }

            return charsCounter;
        }
    }
}
