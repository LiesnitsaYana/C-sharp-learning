using System;
using System.Collections.Generic;

namespace LessonTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> birdsAndPlanes = new List<IFlyable>();
            birdsAndPlanes.Add(new Bird("Kiwi", false)); 
            birdsAndPlanes.Add(new Bird("Falcon", true));
            birdsAndPlanes.Add(new Bird("Penguin", false)); 
            birdsAndPlanes.Add(new Bird("Swan", true));
            birdsAndPlanes.Add(new Plane("Boeing 747", 1200));
            birdsAndPlanes.Add(new Plane("Boeing 767", 800));
            birdsAndPlanes.Add(new Plane("A380", 950));
            birdsAndPlanes.Add(new Plane("A330", 1100));


            foreach (IFlyable item in birdsAndPlanes)
            {
                item.Fly();
            }
        }
    }
}
