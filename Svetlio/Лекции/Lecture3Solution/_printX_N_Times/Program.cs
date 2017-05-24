using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _printX_N_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            //int counterOne = 0;
            //Console.WriteLine("Въведи колко пъти искаш Х да се покаже на конзолата");
            //int number = Int32.Parse(Console.ReadLine());

            //while (counterOne < number)
            //{
            //    Console.WriteLine('X' + number);
            //    counterOne++;
            //}

            int counter = 1;
            Console.WriteLine("Въведи колко реда искаш");
            int num = Int32.Parse(Console.ReadLine());

            while (counter <= num)
            {
                Console.WriteLine("Ред № " + counter++);
                //counter++;
            }
            Console.ReadKey();

            }
        }
    }

