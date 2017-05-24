using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача за почивните дни:
//Изведете ascii таблицата на конзолата от 48 - '0' до 126 - '~'
//http://www.theasciicode.com.ar/ascii-printable-characters/tilde-swung-dash-ascii-code-126.html

namespace homeworkPrintASCIICharachters
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char symbol = (char)48; symbol <= (char)126; symbol++)
            {
                Console.WriteLine("\t {0} \n",symbol); // пиши коментари за останалите (\t - tab   \n - new line)
            }
        }
    }
}
