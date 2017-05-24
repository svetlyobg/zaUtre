using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hristoCircleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int i = 0;
                int j = 0;
                double r;
                Console.WriteLine("Въведи радиус ");

                r = Convert.ToDouble(Console.ReadLine());
                double pixel = 2; // пиксел
                for (i = -Convert.ToInt32(r); i <= r; i++) // цикъл за хоризонталното изчертаване
                {
                    for (j = -Convert.ToInt32(r); j <= r; j++) // цикъл за вертикалното изчертаване
                    {
                        double d = ((i * pixel) / r) * ((i * pixel) / r) + (j / r) * (j / r);
                        if (d > 0.95 && d < 1.08) // апроксимация
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            while (true);
        }
    }
}