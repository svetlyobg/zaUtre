﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Polymorphism
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.Write("Base Draw");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            // draw a circle...
            Console.WriteLine("Circle Draw");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            // draw a rectangle...
            Console.WriteLine("Rect Draw");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape c = new Circle();
            c.Draw();
            //Outputs "Circle Draw"
            Shape r = new Rectangle();
            r.Draw();
        }
    }
}
