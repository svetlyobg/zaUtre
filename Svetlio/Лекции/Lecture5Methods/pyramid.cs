﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Колко реда да е пирамидата?");
                Console.ReadLine(DrawPyramid(0));
            }
            while (true);
            {

            }
        }

        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
