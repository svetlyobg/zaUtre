using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Факториел от 20 = " + Fact(20));
            //Outputs 720
        }

        static long Fact(long num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Fact(num - 1);
        }
    }
}
