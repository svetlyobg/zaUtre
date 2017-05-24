using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Dstuctori
{
    class Cat
    {
        public static int count = 0;
        public Cat()
        {
            count++;
        }
        ~Cat()
        {
            Console.WriteLine("adios");
        }
        class Program
        {
            static void Main(string[] args)
            {
                Cat c1 = new Cat();
                Cat c2 = new Cat();
                Console.WriteLine(Cat.count);
            }
        }
    }
}
