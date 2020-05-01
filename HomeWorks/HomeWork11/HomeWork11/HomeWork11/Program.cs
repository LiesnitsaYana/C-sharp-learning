using System;

namespace HomeWork11
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            Parent mother = new Parent();
            Accountancy accountancy = new Accountancy();

            MyDel eventMother = mother.OnMarkChange;
            MyDel eventAccountancy = accountancy.PayingFellowship;

            stud.Name = "Josefina";

            stud.MarkChange += eventMother;
            stud.MarkChange += eventAccountancy;

            stud.AddMark(65);
            stud.AddMark(71);
            stud.AddMark(95);

            Console.ReadKey();

        }
    }
}
