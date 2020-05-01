using System;

namespace TaskC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We can explain any of errors: 400, 401, 402, 403: ");
            ErrorExplanation(400, Errors.Error400);
            ErrorExplanation(401, Errors.Error401);
            ErrorExplanation(402, Errors.Error402);
            ErrorExplanation(403, Errors.Error403);

        }

        enum Errors
        {
            Error400 = 1,
            Error401,
            Error402,
            Error403
        }

        static void ErrorExplanation(int enteredErrorNumber, Errors errors)
        {
            string explanation = null;
            switch (errors)
            {
                case Errors.Error400:
                    explanation = "Bad Request";
                    break;
                case Errors.Error401:
                    explanation = "Unauthorized";
                    break;
                case Errors.Error402:
                    explanation = "Payment Required";
                    break;
                case Errors.Error403:
                    explanation = "Forbidden";
                    break;
            }
            Console.WriteLine("The explanation of the entered error number is: {0}", explanation);
            Console.ReadKey();
        }
    }
}
