using System;

namespace LessonTask5
{
    public class Bird : IFlyable
    {
        public string name;
        public bool canFly;

        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }

        public void Fly()
        {
            if (canFly == true)
            {
                Console.WriteLine("The bird {0} can fly", name);
            }
            else Console.WriteLine("The bird {0} can not fly", name);
            Console.ReadKey();
        }

       
    }
}
