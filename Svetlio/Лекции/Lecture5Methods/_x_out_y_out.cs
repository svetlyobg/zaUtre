﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _x_out_y_out
{
    class Program
    {
        static void GetValues(out int x, out int y)
        {
            x = 5;
            y = 42;
        }
        static void Main(string[] args)
        {
            int a, b;
            GetValues(out x, out y);
            //Now a equals 5, b equals 42
        }
        
    }
}
