using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int code = 48; code <= 126; code++) // по-малко или равно или < 127 за да можеш да върнеш и код 126 '~'
                //да вярно. защо съм го пропуснал като в homeworkPrintASCIICharachters съм го написал вярно хахах.
            {
                char symbol = (char)code;
                Console.WriteLine("Символът {0} е с код {1}", symbol , code);

            }
        }
    }
}
