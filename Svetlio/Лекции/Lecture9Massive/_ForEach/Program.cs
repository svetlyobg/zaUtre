﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            for (int k = 0; k < a.Length; k++)
            {
                a[k] = k * 2;
                //Console.WriteLine(k);
                Console.WriteLine(a[k]);
            }

            for (int k = 0; k < a.Length; k++)
            {
                a[k] = k + 2;
                Console.WriteLine(a[k]);
            }
          
            foreach (int k in a)
            {
                Console.WriteLine(k);
            }
        }
    }
}
