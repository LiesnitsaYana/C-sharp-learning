using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Person> personsList = new List<Person>();
            //for (int i = 0; i < 6; i++)
            //{
            //    personsList.Add(new Person());
            //}


            //foreach (var per in personsList)
            //{
            //    per.InputInfoAboutPerson();
            //}

            //foreach (var per in personsList)
            //{
            //    per.PersonAgeInfo();
            //}

            //foreach (var per in personsList)
            //{
            //    per.ChangeName();
            //}

            //foreach (var per in personsList)
            //{
            //    per.OutputInfoAboutPerson();
            //}

            //foreach (Person per in personsList)
            //{
            //    foreach (Person per2 in personsList)
            //    {
            //        if (ReferenceEquals(per, per2)) continue;
            //        if (per == per2) Console.WriteLine($"Persons {per.ToString()} and {per2.ToString()} have the same name.");
            //        Console.ReadKey();
            //    }
            //}

            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            Person[] personsArray = new Person[] { person1, person2, person3 };

            person1.InputInfoAboutPerson();
            person2.InputInfoAboutPerson();
            person3.InputInfoAboutPerson();



            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("PersonSer.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, personsArray);
            stream.Close();

            stream = new FileStream("PersonSer.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Person[] per2 = (Person[])formatter.Deserialize(stream);
            foreach (Person p in personsArray)
            {
                Console.Write("Deserialized, got name={0}, year of birth={1}", p.name, p.birthYear);
            }

            stream.Close();
            Console.ReadKey();

            // XML

            XmlSerializer xmlser = new XmlSerializer(typeof(Person[]));
            Stream serialStream = new FileStream("personXML.xml", FileMode.OpenOrCreate);
            xmlser.Serialize(serialStream, personsArray);
            serialStream.Close();

            // De-Serialization

            serialStream = new FileStream("personXML.xml", FileMode.Open);
            Person[] person1de = xmlser.Deserialize(serialStream) as Person[];

            Console.WriteLine("XML De-Serialization");
            foreach (Person p in person1de)
            {
                Console.Write("Deserialized, got name={0}, year of birth={1}", p.name, p.birthYear);
            }

            serialStream.Close();
            Console.ReadKey();

            //JSON 

            Stream file = new FileStream("persons.json", FileMode.OpenOrCreate);
            DataContractJsonSerializer jsonser = new DataContractJsonSerializer(typeof(Person[]));
            jsonser.WriteObject(file, personsArray);
            //file.Close();

            //De-Serialization
            file.Position = 0;
            Person[] personJson = (Person[])jsonser.ReadObject(file);

            Console.WriteLine();
            foreach (Person p in personJson)
            {
                Console.Write("Deserialized, got name={0}, year of birth={1}", p.name, p.birthYear);
            }
            file.Close();
        }
    }
}
