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
			string command = args[0].ToLower();
			if (command == "fuelcounter")
			{
				Program.ExecuteFuelCounter(args[1], isRecursive: false);
			}
			else if (command == "fuelcounterrecursive")
			{
				Program.ExecuteFuelCounter(args[1], isRecursive: true);
			}
		}

		private static void ExecuteFuelCounter(string inputPath, bool isRecursive)
		{
			int sum = 0;
			foreach (string line in File.ReadLines(inputPath))
			{
				if (int.TryParse(line, out int mass))
				{
					if (isRecursive)
					{
						sum += FuelCounter.FuelCounter.CalculateFuelRecursive(mass);
					}
					else
					{
						sum += FuelCounter.FuelCounter.CalculateFuel(mass);
					}
				}
			}

			string recursiveInfo = isRecursive ? " (recursive)" : String.Empty;
			Console.WriteLine($"Sum of input fuel counters{recursiveInfo}: {sum}");
		}
	}
}
