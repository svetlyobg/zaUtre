using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuche
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog fisrDog = new Dog();
            Console.WriteLine("Give me a name");
            fisrDog.name = Console.ReadLine();
            fisrDog.Bark();

        }
    }
    class Dog
    {
        public string name;
         int age = 1;

        public void Bark()
        {
            Console.WriteLine("Wof, wof");
            Console.WriteLine("My name is: " + name);
            Console.WriteLine("My age is: " + age);
        }
    }
}
