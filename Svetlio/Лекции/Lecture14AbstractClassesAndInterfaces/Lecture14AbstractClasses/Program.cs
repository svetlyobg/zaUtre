using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractClassCar
{
    abstract class Car
    {
        public abstract void GetHP();

    }
    class SUV : Car
    {
        int horsePower = 205;
        string fuel = "Gas";
        public override void GetHP()
        {
            Console.WriteLine(horsePower);

        }

    }
    class Van : Car
    {
        int horsePower = 150;
        string fuel = "Diessel";
        public override void GetHP()
        {
            Console.WriteLine(horsePower);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Van();
            Car car2 = new SUV();
            Car[] cars = { car1, car2 };
            car1.GetHP();
            car2.GetHP();
        }
    }
}
