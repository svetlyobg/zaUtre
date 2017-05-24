using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Classes
{
    class Person
    {
        int test = 40;
        int test1 = 70;
        string name = "Mihail";

        int TestResult()
        {
            return test + test1;
        }
        public void PersonInfo()
        {
            Console.WriteLine(name + " " + TestResult());
        }

        public void SayHi()
        {
            Console.WriteLine("Hi");
        }


        static void Main(string[] args)
        {
            //int test;
            Person p = new Person();
            p.PersonInfo();

            Console.ReadKey();
        }

    }
}
