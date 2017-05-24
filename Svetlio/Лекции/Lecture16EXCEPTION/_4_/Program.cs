using System;

namespace _4_
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int x, y;
			try {
				x = Convert.ToInt32(Console.ReadLine());
				y = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(x / y);
			}
			catch (DivideByZeroException e) {
				Console.WriteLine("Cannot divide by 0");
			}
			catch(Exception e) {
				Console.WriteLine("An error occurred");
			}
		}
	}
}
