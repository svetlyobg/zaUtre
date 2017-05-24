using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banan
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Много обичам да ям шоколад. Защото е болезен!";
            Console.WriteLine(s);
            s = s.Replace("шоколад", "банан");
            Console.WriteLine(s);
            s = s.Remove(26);
            Console.WriteLine(s);
            s = s.Replace("обичам да ", "");
            Console.WriteLine(s);

            //int ocur = s.IndexOf("З");
            //s = s.Remove(ocur);
            //Console.WriteLine(s);

            s = s.Remove(s.IndexOf("ям"));
            Console.WriteLine(s);
        }
    }
}
