using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("What is your age?");

            age = Convert.ToInt32(Console.ReadLine());
            age = age + 2;

            Console.WriteLine("After 2 years you will be {0} years old", age);
            Console.ReadKey();
            Console.WriteLine("\a");
           


        }
    }
}
