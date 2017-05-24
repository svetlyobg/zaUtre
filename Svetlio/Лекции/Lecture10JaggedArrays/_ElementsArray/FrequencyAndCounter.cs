using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ElementsArray
{
    class FrequencyAndCounter
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int[] arr = { 1,2,3,4,5,1,2,3,6,6,6,6,6};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("number "+ arr[i] + " is contained " + counter++ + " times");
            }
        }
    }
}
