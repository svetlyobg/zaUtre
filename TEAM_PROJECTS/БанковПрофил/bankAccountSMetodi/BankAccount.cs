using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccountSMetodi
{
    public class Person
    {
        public string username;
        public string password;
        public string firstName;
        private string middleName;
        private string lastName;
        private string fullName;
        private int age;
        private string email;
        private string city;
        private double balanceValue;
        private string balanceCurrency;
        public string balance;
        private string lastDraw;

        public Person(string username, string password, string firstName, string balance)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.balance = balance;
        }

        public string Username => this.username;
        public string Password => this.password;
        public string FirstName => this.firstName;
        public string MiddleName => this.middleName;
        public string LastName => this.lastName;
        public string FullName => this.fullName;
        public int Age => this.age;
        public string Email => this.email;
        public string City => this.city;
        public double BalanceValue => this.balanceValue;
        public string BalanceCurrency => this.balanceCurrency;
        public string Balance => this.balance;
        public string LastDraw => this.lastDraw;

        public string GetPersonInfo()
        {

            return $"\nYour name is {this.firstName} and your balance is {this.balance}";
        }

    }
    class BankAccount
    {

        static void Main(string[] args)
        {

            string inputUsername, inputPassword;
            bool match = false;
            Person krasen = new Person("krasen", "0000", "Krasen Kunev", "1000");
            Person svetlyo = new Person("svet", "5555", "Svetlozar Kosev", "200");
            Person[] masivPotrebiteli = { svetlyo, krasen };

            do
            {
                Console.WriteLine("Enter username");
                inputUsername = Console.ReadLine();

                for (int i = 0; i < masivPotrebiteli.Length; i++)
                {
                    if (inputUsername != masivPotrebiteli[i].username)
                    {
                        match = true;
                    }
                }

            }
            while (match != true);
            {
                Console.WriteLine("User name is corect!");
            }

            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter password");

                inputPassword = Console.ReadLine();

                for (int i = 0; i < masivPotrebiteli.Length; i++)
                {
                    if (inputPassword == masivPotrebiteli[i].password)
                    {
                        match = true;
                    }
                    else
                    {
                    
                    Console.WriteLine("wait 5 sec");
                    System.Media.SystemSounds.Beep.Play();
                    System.Threading.Thread.Sleep(5000);
                }
            }

            }
            while (match != true);
            {
                Console.WriteLine();
                Console.WriteLine("Log in successfully");
            }


    string krasenInfo = krasen.GetPersonInfo();
    string svetInfo = svetlyo.GetPersonInfo();

            if (inputUsername == krasen.username)
            {
                Console.WriteLine(krasenInfo);
            }
            if (inputUsername == svetlyo.username)
            {
                Console.WriteLine(svetInfo);
            }
            else
            {
                Console.WriteLine("Try again");
            }


        }
    }
}
