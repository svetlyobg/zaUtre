using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Въведи първото целочислено събирателно");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Въведи второто целочислено събирателно");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            int result;
            result = a + b;
            Console.WriteLine("Сумата на двете числа е {0}", result);
            Console.ReadKey();

        }
    }
}
