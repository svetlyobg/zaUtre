using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a =0; a<=200; a++)
                if(a%2!=0)
                    Console.WriteLine("{0} is add number", a);
            
            Console.ReadKey();
        }
    }
}
