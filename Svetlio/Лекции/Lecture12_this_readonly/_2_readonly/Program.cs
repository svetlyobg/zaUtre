﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_readonly
{
    class Person
    {
        private readonly string name = "John";
        public Person(string name)
        {
            this.name = name;
        }

        //readonly string name; // OK
        // const double PI; // Error

        //readonly double a = Math.Sin(60); // OK
        //const double b = Math.Sin(60); // Error!

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
