using System;

namespace HomeWork5
{
    public class Programmer : IDeveloper
    {
        private string _language;

        public string Tool
        {
            get { return _language; }
            set { _language = value; }
        }

        public Programmer(string language)
        {
            this._language = language;
        }

        public void Create()
        {
            Console.WriteLine($"The programmer is creating different apps using {_language} program language.");
            Console.ReadKey();
        }

        public void Destroy()
        {
            Console.WriteLine($"The programmer can destroy his code sometimes, even he's using {_language}");
            Console.ReadKey();
        }

        public int CompareTo(object obj)
        {
            IDeveloper dev = (IDeveloper)obj;
            return _language.CompareTo(dev.Tool);

        }
    }
}
