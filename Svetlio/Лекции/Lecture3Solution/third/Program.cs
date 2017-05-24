using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Ivan";
            string b = "Kosev";

            if (a == b)
            {
                Console.WriteLine("Equal");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Not equal");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        
    }
}
