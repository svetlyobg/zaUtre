using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    class Person
    {
        string firstName;
        string lastName;
        int age;
        string currentCity;
        string gender;
        string occupation;

        public void getKrasen()
        {
            age = 23;
            firstName = "Krasen";
            lastName = "Kunev";
            currentCity = "Rome";
            gender = "male";
            occupation = "idiot";
            Console.WriteLine(firstName + " " + age + " godini " + "gender " + gender);
            
        }

        public void getSvetlyo()
        {
            age = 23;
            firstName = "Svetlozar";
            lastName = "Kosev";
            currentCity = "gabrovo";
            gender = "male";
            occupation = "lamer";
            Console.WriteLine(firstName + " " + age + " godini " + "gender " + gender);
        }
    }
   

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Person krasen = new Person();
            Person svet = new Person();


            //krasen.getKrasen();
            if (input == "krasen")
            {
                krasen.getKrasen();
            }
            else
            {
                svet.getSvetlyo();
            }
            Console.WriteLine();
          
            //svet.getSvetlyo();
        }
    }
}
