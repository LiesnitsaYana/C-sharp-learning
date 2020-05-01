using System;

namespace HomeWork5
{
    public class Builder : IDeveloper, IComparable

    {
        private string _tool;

        public string Tool
        {
            get { return _tool; }
            set { _tool = value;  }
        }

        public Builder(string tool)
        {
            this._tool = tool;
        }

        public void Create()
        {
            Console.WriteLine($"The builder is creating buildings using {_tool}.");
            Console.ReadKey();
        }

        public void Destroy()
        {
            Console.WriteLine($"The builder can destroy buildings using {_tool}.");
            Console.ReadKey();
        }

        public int CompareTo(object obj)
        {
        IDeveloper dev = (IDeveloper)obj;
        return _tool.CompareTo(dev.Tool);

        }
    }
}
