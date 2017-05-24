using System;

class LoginPanel
{
    static void Main()
    {

        string username = "admin";
        string inputt = string.Empty;
        string password = "0000";
        string input = string.Empty;
        Console.WriteLine("Bank Account");
        do
        {

            Console.Write("Please enter username :");
            inputt = Console.ReadLine();
        }

        while (inputt != username);
        {
            Console.WriteLine("User name is corect!");
        }
        do
        {

            Console.Write("Please enter the password: ");
            input = Console.ReadLine();
            if (input == password)
            {
                Console.WriteLine("You login successfully!");
            }
            else
            {
                Console.WriteLine("wait 5sec");
                System.Threading.Thread.Sleep(5000);
            }
        }
        while (input != password);
        {
            Console.WriteLine("Please wait a seccond");
            System.Threading.Thread.Sleep(5000);
        }

    }
}


