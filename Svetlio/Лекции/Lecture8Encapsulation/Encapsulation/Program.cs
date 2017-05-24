using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Person
    {
        private int age;
        private string name;
        public Person(string nm, int ag)
        {
            name = nm;
            age = ag;
        }
        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Person p = new Person("David", 50);
                Console.WriteLine(p.getName()+ "\n \r" + p.getAge());
               // Console.WriteLine(p.getAge());
            }
        }
    }
}
