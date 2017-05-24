using System;

namespace Lecture16EXCEPTION
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try
			{
			int[] arr = new int[] { 4, 5, 8 };
			Console.Write(arr[8]);
			}
			catch(Exception e) 
			{
				Console.WriteLine("An error occurred");
			}	
		}
	}
}