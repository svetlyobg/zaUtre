using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи стойност за х");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Въведи стойност за у");
            int y = Int32.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("x is greater");
            }
            if (x < y)
            {
                Console.WriteLine("y  е по голяма");
            }
            if (x == y)
            {
                Console.WriteLine("x = y");
            }
        }
    }
}
/// Да си напишем името в конзола име с малки букви глави букви и да върне фамилията
