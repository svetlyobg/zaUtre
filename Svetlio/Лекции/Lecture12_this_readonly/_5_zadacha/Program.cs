using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_zadacha
{
    public class Dog
    {
        private string[] examination = new string[5];
        public string this[int index]
        {
            get
            {
                return examination[index];
            }
            set
            {
                examination[index] = value;
            }
        }

        public int id { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public int age { get; set; }



    }
    public class Program
    {
        static void Main()
        {
            Console.Write("How many Dogs you want to add?: ");
            int count = int.Parse(Console.ReadLine());

            Dog[] newDogs = new Dog[count];

            for (int i = 0; i < count; i++)
            {
                newDogs[i] = new Dog();
                newDogs[i].id = i;

                Console.WriteLine("Name");
                newDogs[i].name = Console.ReadLine();
               Console.WriteLine("Adress");
               newDogs[i].adress = Console.ReadLine();
                Console.WriteLine("Age");
                newDogs[i].age = int.Parse(Console.ReadLine());

                Console.WriteLine("Describe five items");

                for (int examination = 0; examination < 5; examination++)
                {
                    Console.WriteLine("Item {0} is", examination);
                    newDogs[i][examination] = Console.ReadLine();
                    //bobby[examine] = Console.ReadLine();
                }
            }


            Console.WriteLine("\tId \tDog Name \tAge \tAdress ");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\t" + newDogs[i].id + "\t" + newDogs[i].name + "\t" + newDogs[i].age + "\t" + newDogs[i].adress);
            }

            for (int i = 0; i < count; i++)
            {
                for (int examination = 0; examination < 5; examination++)
                {
                    Console.WriteLine(newDogs[i].name);
                    Console.WriteLine("Examination {0} is {1}", examination, newDogs[i][examination]);
                }
            }
            Console.ReadKey();
        }
    }
}
