using System;

namespace _5_Finally
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int result=0;
			int num1 = 8;
			int num2 = 4;
			try {
				result = num1 / num2;
			}
			catch (DivideByZeroException e) {
				Console.WriteLine("Error");
			}
			finally {
				Console.WriteLine(result);
			}
		}
	}
}
