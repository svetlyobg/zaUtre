using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsCommonBetweenPeople
{
    public class Human
    {
        public int age;
        public string firstName;
        public string LastName;
        public string gender ;
        public string hairColor;
        public int numberOfEYEs ;
        public int numbeOfLegs ;
        public double size;
        
        public void PersonInfo()
        {
            //Console.WriteLine("Инфо за жени");
        }
        public void TodorInfo()
        {
            //Console.WriteLine("Инфо за мъже");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Human deshka = new Human();
            Human todor = new Human();
            todor.gender = "МЪЖ";

            deshka.PersonInfo();
            deshka.age = 37;
            deshka.firstName = "ДЕШКА";
            deshka.gender = "ЖЕНА";

            Console.WriteLine("Аз съм на " + deshka.age + " години " + "името ми е "+ deshka.firstName+ "и съм от пол " + deshka.gender);

            todor.TodorInfo();
            Console.WriteLine("АЗ ТОДОР ПЪК СЪМ "+ todor.gender);

            Console.ReadLine();
        }

    }
}
