using System;

namespace _8_excercise
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int size = 0;

			bool exit = false;
			while (exit == false)
			{
				try
				{
					Console.WriteLine("What is the size of array? ");
					size = Convert.ToInt32(Console.ReadLine());
					exit = true;
				}

				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}

			}
			exit = false;

			int[] arr = new int[size];

			for (int i = 0; i < arr.Length; i++)
			{
				while (exit == false)
				{
					try
					{
						Console.WriteLine("Enter " + i + " element");
						arr[i] = Convert.ToInt32(Console.ReadLine());
						exit = true;
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
				exit = false;
			}

			int first = arr[0];
			for (int i = 0; i < arr.Length; i++)
			{

				if (i == arr.Length - 1)
				{
					arr[i] = arr[i] + first;

				}
				else
				{
					arr[i] = arr[i] + arr[i + 1];
				}

			}
			for (int i = 0; i < arr.Length; i++)
			{

				Console.WriteLine(arr[i]);
			}

		}
	}
}
