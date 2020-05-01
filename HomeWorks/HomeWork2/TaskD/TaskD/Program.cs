using System;

namespace TaskD
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog;
            myDog.dogName = "Chapi";
            myDog.dogMark = "Dvor-terrier";
            myDog.dogAge = 5;
            Console.WriteLine(myDog);
            Console.ReadLine();
        }

        public struct Dog
        {
            public string dogName;
            public string dogMark;
            public int dogAge;

            public override string ToString()
            {
                return string.Format("The dog {0} is {1} and she is {2} years old.", dogName, dogMark, dogAge);
            }
        }
    }
}
