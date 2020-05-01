using System;

namespace HomeWork11
{
    public class Parent : Student
    {
        public void OnMarkChange(int markAdded)
        {
            Console.WriteLine($"MOTHER: My daughter has this new mark: {markAdded}.");
        }
    }
}
