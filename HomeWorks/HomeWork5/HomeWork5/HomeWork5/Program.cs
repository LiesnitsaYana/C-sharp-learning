using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> devList = new List<IDeveloper>();

            devList.Add(new Builder("Hammer and Nails"));
            devList.Add(new Builder("Power Drill"));
            devList.Add(new Builder("Saw"));
            devList.Add(new Programmer("C#"));
            devList.Add(new Programmer("Java"));
            devList.Add(new Programmer("Python"));

            devList.Sort();

            foreach (var developer in devList)
            {
                developer.Create();
                developer.Destroy();
            }

            //=== Second task ===================

            Dictionary<uint,string> persons = new Dictionary<uint,string>();

            uint keyPerson = 0;
            string valuePerson = null;
            uint idSerchingPerson = 0;
            
            Console.WriteLine("Enter 7 persons using an integer as user ID and a string as user name.");

            try
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("Enter user ID: ");
                    keyPerson = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("Enter user name: ");
                    valuePerson = Convert.ToString(Console.ReadLine());
                    persons.Add(keyPerson, valuePerson);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format!");
                Console.ReadKey();
            }
            

            foreach (KeyValuePair<uint,string> keyValue in persons)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.ReadKey();


            try
            {
                Console.WriteLine("Enter the ID of the user who you interested in: ");
                idSerchingPerson = Convert.ToUInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format!");
                Console.ReadKey();
            }

            if (persons.TryGetValue(idSerchingPerson, out valuePerson))
                Console.WriteLine($"The person's name with ID {idSerchingPerson} is " + valuePerson);
            else
                Console.WriteLine($"Oops! The person with ID {idSerchingPerson} doesn't exist.");

            Console.ReadKey();
        }
    }
}
