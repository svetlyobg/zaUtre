using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kucheto
{
    class Dog
    {
        private string name = "Krasen";
        public Dog()
        {
            Console.WriteLine("Имате ново куче!");
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog bob = new Dog();
            // bob.name = "Bobby";
            bob.age = 3;
            Console.WriteLine("На " + bob.age + " години е моето куче " + bob.Name);
        }
    }
}
