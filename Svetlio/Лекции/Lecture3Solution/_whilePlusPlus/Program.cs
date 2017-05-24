using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _whilePlusPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num < 6)
            {
                Console.WriteLine(++num);
                //num++;
            }
        }
    }
}
