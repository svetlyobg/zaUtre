using System;

namespace _6_zadacha
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int [] arr= new int[10];
			Console.WriteLine ("Enter 10 integers");
			int n = Int32.Parse (Console.ReadLine ());
			try
			{
			for (int i = 0; i < arr.Length; i++)
			{
				arr [i] =Int32.Parse(Console.ReadLine ());	
			}
			}
			catch (Exception e)
			{
				Console.WriteLine("\nI said integer!\nCAN'T YOU READ MA\'AFAKAR???");
			}

		}
	}
}
