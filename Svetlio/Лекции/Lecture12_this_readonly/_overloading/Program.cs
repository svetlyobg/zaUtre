using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _overloading
{
    class Box
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Box(int h, int w)
        {
            Height = h;
            Width = w;
        }
    }
    class Program
    {
        static void Main()
        {
            Box b1 = new Box(14, 3);
            Box b2 = new Box(5, 7);
        }
    }
}
