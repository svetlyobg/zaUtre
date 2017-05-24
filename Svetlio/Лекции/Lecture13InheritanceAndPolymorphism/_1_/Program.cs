using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_
{
    class Animal
    {
        protected int Legs { get; set; }
        protected int Age { get; set; }
        
        public void GetAnimalLegs()
        {
            Console.WriteLine(Legs);
        }
    }
    class Dog : Animal
    {
        public Dog()
        {
            Legs = 4;
            Age = 1;
        }
        public void Bark()
        {
            Console.WriteLine("Woof");
        }
    }
    class Cat : Animal
    {
        public Cat()
        {
            Age = 2;
            Legs = 5;
        }
        public void Meww()
        {
            Console.WriteLine("Meww");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();

            // Outputs 4
            d.GetAnimalLegs();
            d.Bark();

            Cat c = new Cat();
            c.GetAnimalLegs();
            c.Meww();
            //Outputs "Woof"
        }
    }
}