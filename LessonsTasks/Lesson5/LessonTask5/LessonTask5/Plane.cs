using System;

namespace LessonTask5
{
    public class Plane : IFlyable
    {
        public string mark;
        public int highFly;

        public Plane(string mark, int highFly)
        {
            this.mark = mark;
            this.highFly = highFly;
        }

        public void Fly()
        {
            Console.WriteLine("The plane {0} is flying on {1} km high", mark, highFly);
            Console.ReadKey();
        }
    }
}
