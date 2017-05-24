using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _string
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender;
            Console.WriteLine("What is your gender?");
            gender = Console.ReadLine();
            if (gender == "male" /*|| "female"*/)
            Console.WriteLine("Your gender is: {0} ", gender);
            else
                Console.WriteLine("This is not a gender!");
            Console.ReadKey();
        }
    }
}
