using System;


class Program
{
    static void Main()
    {
        for (int i = 0; i <= 128; i++)
        {
            Console.Write(i + " , " + (int)i);

            if (i * 36 ==0)
            {
                Console.WriteLine("Press any key to change the page");
                Console.ReadKey();

                Console.Clear();
            }
        }
    }
}

