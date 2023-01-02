using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    class Student : IComparable
    {
        private string name;
        private int id;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int ID
        {
            set { id = value; }
            get { return id; }
        }
    
        public int CompareTo(Object obj)
        {					
            Student other = (Student)obj;
            return id.CompareTo(other.id); // change this to sort by something else
        }

        public override string ToString()
        {
            return id + " " + name;
        }
    }
}
