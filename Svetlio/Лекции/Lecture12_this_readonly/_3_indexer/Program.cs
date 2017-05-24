using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_indexer
{
    class Clients
    {
        private string[] names = new string[10];
        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            string str = "Hello World";
            char x = str[4];
            Console.WriteLine(x);
            //Outputs "o"   

            Clients c = new Clients();
            c[0] = "Dave";
            c[1] = "Bob";
            Console.WriteLine(c[1]);
            //Outputs "Bob"
        }
    }
}
