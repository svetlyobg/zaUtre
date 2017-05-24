using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Person
    {
        public string personUsername;
        public string pinCode;
        public string firstName;
        public string middleName;
        public string lastName;
        public string fullName;
        public int age;
        public string email;
        public string city;
        public double balanceValue;
        public string balanceCurrency;
        public string lastDraw;
        public string balance;

        //public Person()
        //{
        //    Console.WriteLine("Welcome back, {0}", fullName);
        //}

    }
    class Program
    {
        //static void PersonInfo()
        //{

        //}

        static void Main(string[] args)
        {
            string username ;
            string inputUsername = string.Empty;
            string password;
            string inputPassword = string.Empty;

            Person krasen = new Person();

            krasen.personUsername = username = "krasen";
            krasen.pinCode = password = "0000";
            krasen.firstName = "Krasen";
            krasen.middleName = "Ivanov";
            krasen.lastName = "Kunev";
            krasen.fullName = krasen.firstName + " " + krasen.middleName + " " + krasen.lastName;
            krasen.age = 23;
            krasen.email = "plebo93@gmail.com";
            krasen.city = "Sevlievo";
            krasen.balanceValue = 1000;
            krasen.balanceCurrency = " leva";
            krasen.lastDraw = "10.02.2017";
            krasen.balance = krasen.balanceValue + krasen.balanceCurrency;

            Person svetlyo = new Person();

            svetlyo.personUsername = username = "svet";
            svetlyo.pinCode = password = "5555";
            svetlyo.firstName = "Svetlozar";
            svetlyo.middleName = "Vladkov";
            svetlyo.lastName = "Kosev";
            svetlyo.fullName = svetlyo.firstName + " " + svetlyo.middleName + " " + svetlyo.lastName;
            svetlyo.age = 23;
            svetlyo.email = "swk_12@abv.bg";
            svetlyo.city = "Gabrovo";
            svetlyo.balanceValue = 13000;
            svetlyo.balanceCurrency = " leva";
            svetlyo.lastDraw = "10.04.2017";
            svetlyo.balance = svetlyo.balanceValue + svetlyo.balanceCurrency;

            Person rumi = new Person();

            rumi.personUsername = username = "rumilmar";
            rumi.pinCode = password = "5704";
            rumi.firstName = "Rumiana";
            rumi.middleName = "Milkova";
            rumi.lastName = "Koseva";
            rumi.fullName = rumi.firstName + " " + rumi.middleName + " " + rumi.lastName;
            rumi.age = 60;
            rumi.email = "rumilmar@abv.bg";
            rumi.city = "Gabrovo";
            rumi.balanceValue = 20000;
            rumi.balanceCurrency = " leva";
            rumi.lastDraw = "03.05.2017";
            rumi.balance = rumi.balanceValue + rumi.balanceCurrency;

            do
            {
                Console.Write("Please enter username :");
                inputUsername = Console.ReadLine();
            }
            while (inputUsername != username);
            {
                Console.WriteLine("User name is corect!");
            }

            do
            {
                Console.WriteLine();
                Console.Write("Please enter the password: ");
                inputPassword = Console.ReadLine();

                //string userChoise = Console.ReadLine();

                
                if (inputPassword == password)
                {
                    Console.WriteLine("You login successfully!");
                    Console.WriteLine();
                    
                }
                else
                {
                    Console.WriteLine("wait 5 sec");
                    //Console.WriteLine("\a");
                    System.Media.SystemSounds.Beep.Play();
                    System.Threading.Thread.Sleep(5000);
                }
            }


            while (inputPassword != password);

            //if (input == password)
            //{
            //    Console.WriteLine("You login successfully!");
            //}
            //else
            //{
            //    System.Threading.Thread.Sleep(10000);
            //}


            //PersonInfo();
            Console.WriteLine("Press 1 to view your balance");
            Console.WriteLine("Press 2 to view your last draw");
            Console.WriteLine("Press 3 to close");
            Console.WriteLine("Press 4 to go back");

            //string userChoise = Console.ReadLine();

            if (inputUsername == "svet")
            {
                switch (inputUsername)
                {
                    case "1":
                        Console.WriteLine("Your balance is " + svetlyo.balance);
                        break;
                    case "2":
                        Console.WriteLine("Your last draw was on " + svetlyo.lastDraw);
                        break;
                    case "3":
                        Console.WriteLine("Exit now");
                        Environment.Exit(-1);
                        break;
                    case "4":
                        Console.WriteLine("back");
                        break;
                }
            }
            if (inputUsername == "krasen")
            {
                switch (inputUsername)
                {
                    case "1":
                        Console.WriteLine("Your balance is " + krasen.balance);
                        break;
                    case "2":
                        Console.WriteLine("Your last draw was on " + krasen.lastDraw);
                        break;
                    case "3":
                        Console.WriteLine("Exit now");
                        Environment.Exit(-1);
                        break;
                    case "4":
                        Console.WriteLine("back");
                        break;
                }
            }
            if (inputUsername == "rumilmar")
            {
                switch (inputUsername)
                {
                    case "1":
                        Console.WriteLine("Your balance is " + rumi.balance);
                        break;
                    case "2":
                        Console.WriteLine("Your last draw was on " + rumi.lastDraw);
                        break;
                    case "3":
                        //Console.WriteLine("Exit now");
                        Environment.Exit(-1);
                        break;
                    case "4":
                        Console.WriteLine("back");
                        break;
                }
            }

        }

    }
}