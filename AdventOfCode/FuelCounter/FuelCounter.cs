using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.FuelCounter
{
	public static class FuelCounter
	{
		/// <summary>
		/// Main method for advent of code 2019 day 1 found here: https://adventofcode.com/2019/day/1
		/// </summary>
		/// <param name="mass"></param>
		/// <returns></returns>
		public static int CalculateFuel(int mass)
		{
			// it's non-sensical to require negative amounts of fuel, so always return at least 0
			return Math.Max(mass / 3 - 2, 0);
		}
	}
}
