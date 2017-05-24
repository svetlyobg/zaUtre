using System;

namespace _2_
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a;
			Console.WriteLine ("Enter integer");
			try
			{
				a  = Convert.ToInt32(Console.ReadLine());
				Console.Write(a);
			}
			catch(Exception e) 
			{
				Console.WriteLine("\nI said integer!\nCAN'T YOU READ MA\'AFAKAR???");
			}	
		}
	}
}
