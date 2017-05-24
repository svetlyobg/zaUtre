﻿using System;

namespace _2_
{
	class MainClass
	{
		enum TrafficLights { Green, Red, Yellow };
		public static void Main (string[] args)
		{
			TrafficLights x = TrafficLights.Red;
			switch (x) {
			case TrafficLights.Green:
				Console.WriteLine("Go!");
				break;
			case TrafficLights.Red:
				Console.WriteLine("Stop!");
				break;
			case TrafficLights.Yellow:
				Console.WriteLine("Caution!");
				break;
			}
			//Outputs "Stop!"
		}
	}
}
