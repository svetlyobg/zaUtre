using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ProtectedPerson
{
    class Person
    {
        protected int Age { get; set; }
        protected string Name { get; set; }
    }
    class Student : Person
    {
        public Student(string nm)
        {
            Name = nm;
        }
        public void Speak()
        {
            Console.WriteLine("Name: " + Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("David");
            s.Speak();
        }
    }
}
