using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plusPlusSymbol
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num++ < 6)
            {
                Console.WriteLine(num);

            }
            Console.WriteLine("num++");
            Console.WriteLine();

            int numTwo = 0;
            while (++numTwo < 6)
            {
                Console.WriteLine(numTwo);
            }
            
            Console.WriteLine("++num");
            Console.WriteLine();

            //int a = 1;
            //while (true)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}

        }
    }
}
