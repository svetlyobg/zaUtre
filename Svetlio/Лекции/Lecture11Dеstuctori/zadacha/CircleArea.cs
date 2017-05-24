using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    static class Circle
    {
        private static double lenght = 0;
        public static double getLenght(double r, double PI)
        {

            lenght = (Math.PI * (Math.Pow(r, 2)));
            return lenght;
        }

        public static double getRadius(double r)
        {
            return r;
        }

        private static double d = 0;
        public static double getDiamater(double r)
        {
            d = r * r;
            return d;
        }

        private static double area = 0;
        public static double getArea(double r, double PI)

        {

            area = (2 * Math.PI * r);
            return area;
        }

    }
    class CircleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius");
            double r = Double.Parse(Console.ReadLine());
            Console.WriteLine("radius is " + Circle.getRadius(r) +"\n");
            Console.WriteLine("diameter is " + Circle.getDiamater(r) + "\n");
            Console.WriteLine("The lenght is " + Circle.getLenght(r, Math.PI) + "\n");
            Console.WriteLine("The Area is " + Circle.getArea(r, Math.PI) + "\n");
            
            
        }
    }
}
