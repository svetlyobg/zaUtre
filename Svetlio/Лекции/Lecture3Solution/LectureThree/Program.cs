using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 4;

            if (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Y is greater than X");
                }
                else
                {
                    Console.WriteLine("X is greater than Y");
                }
            }            
            else
            {
                Console.WriteLine("X is equal to Y");    
            }
            Console.ReadKey();
        }
    }
}