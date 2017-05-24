using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Person
    {
        string personUsername;
        string password;
        string firstName;
        string middleName;
        string lastName;
        string fullName;
        int age;
        string email;
        string city;
        double balanceValue;
        string balanceCurrency;
        string lastDraw;
        string balance;

        public void krasen()
        {
            personUsername = "krasen";
            password  = "0000";
            firstName = "Krasen";
            middleName = "Ivanov";
            lastName = "Kunev";
            fullName = firstName + " " + middleName + " " + lastName;
            age = 23;
            email = "plebo93@gmail.com";
            city = "Sevlievo";
            balanceValue = 1000;
            balanceCurrency = " leva";
            lastDraw = "10.02.2017";
            balance = balanceValue + balanceCurrency;
            Console.WriteLine("Welcome back, {0}", fullName);
        }

        public void svetlyo()
        {
            personUsername = "svet";
            password = "5555";
            firstName = "Svetlozar";
            middleName = "Vladkov";
            lastName = "Kosev";
            fullName = firstName + " " + middleName + " " + lastName;
            age = 23;
            email = "swk_12@abv.bg";
            city = "Gabrovo";
            balanceValue = 13000;
            balanceCurrency = " leva";
            lastDraw = "10.04.2017";
            balance = balanceValue + balanceCurrency;
        }

    }
    class Program
    {
        //static void PersonInfo()
        //{

        //}

        static void Main(string[] args)
        {
            //string username ;
            string username = string.Empty;
            //string password;
            string password = string.Empty;

            Person krasen = new Person();

            

            Person svetlyo = new Person();

            

            //Person rumi = new Person();

            //rumi.personUsername = username = "rumilmar";
            //rumi.pinCode = password = "5704";
            //rumi.firstName = "Rumiana";
            //rumi.middleName = "Milkova";
            //rumi.lastName = "Koseva";
            //rumi.fullName = rumi.firstName + " " + rumi.middleName + " " + rumi.lastName;
            //rumi.age = 60;
            //rumi.email = "rumilmar@abv.bg";
            //rumi.city = "Gabrovo";
            //rumi.balanceValue = 20000;
            //rumi.balanceCurrency = " leva";
            //rumi.lastDraw = "03.05.2017";
            //rumi.balance = rumi.balanceValue + rumi.balanceCurrency;

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