using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _switchValues
{
    class Program
    {
        static void switchValues(int x, int y)
        {

            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Първото число след размяната = " + x);
            Console.WriteLine("Второто число след размяната = " + y);

        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Въведи първото число");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Въведи второто число число");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine(); 

            Console.WriteLine("Първото число преди размяната = " + a);
            Console.WriteLine("Второто число преди размяната = " + b);
            Console.WriteLine();

            switchValues(a, b);
        }
    }
}
