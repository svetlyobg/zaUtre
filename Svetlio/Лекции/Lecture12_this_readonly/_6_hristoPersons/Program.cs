using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_hristoPersons
{
    class Person
    {
        private string[] items = new string[5];
        public string this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
        //Person object id
        public int id { get; set; }

        //Persons name
        public string name { get; set; }

        //Persons adress
        public string adress { get; set; }

        //Persons age
        public int age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many persons you want to add?: ");
            int count = int.Parse(Console.ReadLine());

            Person[] newPersons = new Person[count];

            for (int i = 0; i < count; i++)
            {

                newPersons[i] = new Person();
                newPersons[i].id = i;

                Console.WriteLine("Name");
                newPersons[i].name = Console.ReadLine();
                Console.WriteLine("Adress");
                newPersons[i].adress = Console.ReadLine();
                Console.WriteLine("Age");
                newPersons[i].age = int.Parse(Console.ReadLine());

                Console.WriteLine("Describe five items");

                for (int item = 0; item < 5; item++)
                {
                    Console.WriteLine("Item {0} is", item);
                    newPersons[i][item] = Console.ReadLine();
                    bobby[examine] = Console.ReadLine();
                }
            }


            Console.WriteLine("\tId \tClient Name \tAge \tAdress");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\t" + newPersons[i].id + "\t" + newPersons[i].name + "\t" + newPersons[i].age + "\t" + newPersons[i].adress);
            }

            for (int i = 0; i < count; i++)
            {
                for (int item = 0; item < 5; item++)
                {

                    Console.WriteLine(newPersons[i].name);
                    Console.WriteLine("Item {0} is {1}", item, newPersons[i][item]);

                }

            }

            Console.ReadKey();
        }
    }
}
