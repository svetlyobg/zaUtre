using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_InheritPerson
{
    class Person
    {
        public void Speak()
        {
            Console.WriteLine("Hi there");
        }
    }
    class Student : Person
    {
        int number;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Speak();
            //Outputs "Hi there"
        }
    }
}
