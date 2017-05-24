using System;

namespace _1_
{
	class MainClass
	{
		enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
		public static void Main (string[] args)
		{
			int x = (int)Days.Tue;
			Console.WriteLine(x);
			//Outputs 2
		}
	}
}
