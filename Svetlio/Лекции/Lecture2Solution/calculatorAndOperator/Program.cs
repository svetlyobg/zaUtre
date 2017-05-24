//Цeлоцислен калкулатор + избор на математически операции © инж. Светлозар Косев
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorAndOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Въведи първото целочислено число");
                int firstNumber = Int32.Parse(Console.ReadLine()); //потребителят въвежда число от тип int (целочислен)

                //string myFirstChoise = firstNumber.ToString();
                //if (myFirstChoise == "exit")
                //    break;

                Console.WriteLine();

                Console.WriteLine("Избери операция + - / * %");

                char operationSymbol = Convert.ToChar(Console.ReadLine());
                /* в char се запазва символът на избраната операция.
                Ако типът е string редът ще изглежда така
                string operationSymbol = Console.ReadLine();
                 */

                Console.WriteLine();

                Console.WriteLine("Въведи второто целочислено число");
                int secondNmber = Int32.Parse(Console.ReadLine()); // потребителят въвежда второто число

                Console.WriteLine();

                if (operationSymbol == '+') // проверка, ако потребителят е въвел знак за събиране
                {
                    Console.WriteLine("Сумата на двете числа е {0}", firstNumber + secondNmber);
                }
                if (operationSymbol == '-') // проверка, ако потребителят е въвел знак за изваждане
                {
                    Console.WriteLine("Разликата на двете числа е {0}", firstNumber - secondNmber);
                }
                if (operationSymbol == '/') // проверка, ако потребителят е въвел знак за делене
                {
                    Console.WriteLine("Частното на двете числа е {0}", firstNumber / secondNmber);
                }
                if (operationSymbol == '*') // проверка, ако потребителят е въвел знак за умножение
                {
                    Console.WriteLine("Произведението на двете числа е {0}", firstNumber * secondNmber);
                }
                if (operationSymbol == '%') // проверка, ако потребителят е въвел знак за делене по модул
                {
                    Console.WriteLine("Деленито по модул на двете числа е {0}", firstNumber % secondNmber);
                }
                Console.WriteLine();
                ConsoleColor oldColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Цeлоцислен калкулатор инж.Светлозар Косев");
                Console.ForegroundColor = oldColor;
                Console.WriteLine();
                // Console.ReadKey(); //конзолата чака потребителят да натисне клавиш за да се затвори тя.      
            }
            while (true);
        }
    }
}
