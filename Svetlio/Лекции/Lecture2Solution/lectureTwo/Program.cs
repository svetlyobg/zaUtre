using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectureTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10 % 4;
            //Console.WriteLine(x);

            int num = 4965721;
            Console.WriteLine("The number is: " + num);
            Console.WriteLine();
            if(num% 2==0)
            {
                Console.WriteLine("Even");
            }
            else
                Console.WriteLine("Odd");
            
            }
    }
}
