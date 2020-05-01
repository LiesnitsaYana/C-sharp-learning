using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace HomeWork4
{
    [Serializable]

    [DataContract]
    public class Person
    {
        [XmlAttribute]
        [DataMember]
        public string name;
        [XmlAttribute]
        [DataMember]
        public DateTime birthYear;

        public string Name { get; }
        public DateTime BirthYear { get; }

        public Person()
        {

        }

        public Person(string name, DateTime birthYear)
        {
            Name = name;
            BirthYear = birthYear;

        }

        public int AgeCounter()
        {
            int age = DateTime.Today.Year - birthYear.Year;
            return age;
        }

        public void PersonAgeInfo()
        {
            int age = DateTime.Today.Year - birthYear.Year;
            Console.WriteLine($"{name}'s age is {age}.");
            Console.ReadKey();
        }

        public void InputInfoAboutPerson()
        {
            try
            {
                Console.Write("Enter the name: ");
                name = Console.ReadLine();
                Console.Write("Enter the date of birth: ");
                birthYear = Convert.ToDateTime(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format of the input!");
                Console.ReadKey();
            }
        }

        public void ChangeName()
        {
            string newName = "Very Young";
            if (AgeCounter() < 16)
                name = newName;
        }

        public void OutputInfoAboutPerson()
        {

            Console.WriteLine("Person " + name + " was born " + birthYear + ". " + name + "'s age is " + AgeCounter());
            Console.ReadKey();
        }

        public static bool operator ==(Person first, Person second)
        {
            return first.name == second.name;
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }

        public override string ToString()
        {
            return "Person " + name + " was born " + birthYear + ". " + name + "'s age is " + AgeCounter();
        }
    }
}
