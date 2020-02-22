using System;
using System.IO;

namespace AdventOfCode
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				Console.WriteLine("hello world");
			}
			string command = args[0];
			if (command.ToLower() == "fuelcounter")
			{
				Program.ExecuteFuelCounter(args[1]);
			}
		}

		private static void ExecuteFuelCounter(string inputPath)
		{
			int sum = 0;
			foreach (string line in File.ReadLines(inputPath))
			{
				if (int.TryParse(line, out int mass))
				{
					sum += FuelCounter.FuelCounter.CalculateFuel(mass);
				}
			}

			Console.WriteLine($"Sum of input fuel counters: {sum}");
		}
	}
}
