﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Да си напишем името в конзола име с малки букви глави букви и да върне фамилията
namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи първото си име");
            string firstName = Console.ReadLine();

            if (firstName == "Светлозар")
            {
                Console.WriteLine();
                Console.WriteLine("Името ти е {0} Косев", firstName);
            }
            if (firstName == "светлозар")
            {
                Console.WriteLine();
                Console.WriteLine("Името ти е {0} косев", firstName);
            }
            if (firstName == "СВЕТЛОЗАР")
            {
                Console.WriteLine();
                Console.WriteLine("Името ти е {0} КОСЕВ", firstName);
            }
            if ((firstName != "Светлозар") || (firstName != "светлозар") || (firstName != "СВЕТЛОЗАР"))
            {
                Console.WriteLine();
                Console.WriteLine("Нямаш нищо общо със Светлозар");
            }
        }
    }
}
