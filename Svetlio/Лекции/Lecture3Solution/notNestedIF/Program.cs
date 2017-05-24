using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notNestedIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 4;

            if (x == y)
            {
                Console.WriteLine("Y and X are equal");
            }
            else
            {
                if (x > y)
                {
                    Console.WriteLine("X is greater than Y");
                }
                else
                {
                    Console.WriteLine("Y is greater than Y");
                }
            }
            Console.ReadKey();
        }
    }
}
