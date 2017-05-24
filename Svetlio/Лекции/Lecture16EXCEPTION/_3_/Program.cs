using System;

namespace _3_
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try {
				int[] arr = new int[] { 4, 5, 8 };
				Console.Write(arr[8]);
			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
			}
			// Index was outside the bounds of the array.
		}
	}
}
