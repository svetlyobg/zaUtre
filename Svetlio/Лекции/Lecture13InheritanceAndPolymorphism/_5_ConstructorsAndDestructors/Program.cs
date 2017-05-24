using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ConstructorsAndDestructors
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal created");
        }
        ~Animal()
        {
            Console.WriteLine("Animal deleted");
        }
    }
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog created");
        }
        ~Dog()
        {
            Console.WriteLine("Dog deleted");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Animal A = new Animal();
            Dog D = new Dog();
        }
    }
}
