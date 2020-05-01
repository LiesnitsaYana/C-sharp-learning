using System.Collections.Generic;

namespace HomeWork11
{
    public delegate void MyDel(int m);

    public class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<int> marks = new List<int>();

        public event MyDel MarkChange;

        public void AddMark(int markAdded)
        {
            marks.Add(markAdded);
            MarkChange?.Invoke(markAdded);
        }

    }
}
