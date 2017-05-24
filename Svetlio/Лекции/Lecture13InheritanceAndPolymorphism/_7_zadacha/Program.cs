using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_zadacha
{
    public class Car
    {
        protected string name { get; set; }
        protected string color { get; set; }
        protected int numberOfDoors { get; set; }
        protected int numberOfWheels { get; set; }
        protected bool rearCam { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"\n{this.name} is {this.color} color and has {this.numberOfDoors} doors. ");
            Console.WriteLine($"Also has {this.numberOfWheels} wheels and availabily of rear cam {this.rearCam}.");
        }
        
    }
    class CityCar : Car
    {
        //public void GetInfo()
        //{
        //    Console.WriteLine($"The car is {this.color} and has {this.numberOfDoors}. Also has {this.numberOfWheels} and availabily of rear cam {this.rearCam}."  );
        //}
        public CityCar()
        {
            name = "City Car";
            color = "white";
            numberOfDoors = 5;
            numberOfWheels = 4;
            rearCam = true;
        }
    }
    class Golf : Car
    {
        public Golf()
        {
            name = "Golfer car";
            color = "white";
            numberOfDoors = 0;
            numberOfWheels = 3;
            rearCam = false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CityCar cc = new CityCar();
            cc.GetInfo();

            Golf g = new Golf();
            g.GetInfo();
        }
    }
}
