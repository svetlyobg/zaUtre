using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5Methods
{
    class Program
    {
        static void Func(int x)
        {
            Console.WriteLine(x * 2);
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void print(int a)
        {
            Console.WriteLine(a);
        }

        static int Pow(int d, int j = 2)
        {
            int result = 1;
            for (int i = 0; i < j; i++)
            {
                result *= d;
            }
            return result;
        }

        static int Sbor(int firstNumber, int secondNmber)
        {
            Console.WriteLine("enter first number");
            firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            secondNmber = Int32.Parse(Console.ReadLine());

            int resultTwo = firstNumber + secondNmber;
            return resultTwo;
        } // метод за събиране

        static int Razlika(int firstMinus, int secondMinus) // метод за разлика
        {
            Console.WriteLine("enter first number");
            firstMinus = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            secondMinus = Int32.Parse(Console.ReadLine());

            int resultThree = firstMinus - secondMinus;
            return resultThree;
        }
        static void Main(string[] args)
        {
            Func(5);
            //Outputs 10
            Func(12);
            //Outputs 24
            Func(42);
            //Outputs 84

            int res = Sum(11, 42);
            Console.WriteLine(res);

            print(res);
            Pow(7, 5);
            Console.WriteLine("sum is: " + Sbor(0, 0));

            Console.WriteLine("razlikata e: " + Razlika(0,0));
        }
    }
}
