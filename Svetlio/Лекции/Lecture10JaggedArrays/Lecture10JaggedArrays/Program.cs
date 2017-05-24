using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[100,100,100];
            Console.WriteLine("Рангът на матрицата е "+ arr.Rank);
            int[] arr2 = {1,2,3,4,5,6 };
            Console.WriteLine("Най-малкото число е "+arr2.Min());
            Console.WriteLine("Най-голямо число е " + arr2.Max());
            Console.WriteLine("Сумата на числата е "+ arr2.Sum());

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
