using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Interfaces
{
    public interface Icurve
    {
        int Thickness { get; set; }
    }
    public interface IShape
    {
        int Area { get; set; }
        void Draw();
    }
    class Circle : IShape
    {
        public int Area { get; set; }
        public int Thickness { get; set; }

        public void Draw()
        {
            Console.WriteLine("Circle Draw");
        }
        int mass;
    }
    class Program
    {
        static void Main(string[] args)
        {
            IShape c = new Circle();
            c.Area = 5;
            c.Draw();
        }
    }
}

