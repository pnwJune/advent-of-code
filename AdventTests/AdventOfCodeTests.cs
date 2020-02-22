using AdventOfCode.FuelCounter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCodeTests
{
	[TestClass]
	public class FuelCounterTests
	{
		[TestMethod]
		public void TestSimpleCalculation()
		{
			// these test cases are all provided in the problem documentation at https://adventofcode.com/2019/day/1
			int result = FuelCounter.CalculateFuel(12);
			Assert.AreEqual(result, 2);

			result = FuelCounter.CalculateFuel(14);
			Assert.AreEqual(result, 2);

			result = FuelCounter.CalculateFuel(1969);
			Assert.AreEqual(result, 654);

			result = FuelCounter.CalculateFuel(100756);
			Assert.AreEqual(result, 33583);
		}

		[TestMethod]
		public void TestZero()
		{
			Assert.AreEqual(FuelCounter.CalculateFuel(0), 0);
		}

		[TestMethod]
		public void TestSimpleCalculationRecursive()
		{
			// these test cases are all provided in the problem documentation at https://adventofcode.com/2019/day/1
			int result = FuelCounter.CalculateFuelRecursive(12);
			Assert.AreEqual(result, 2);

			result = FuelCounter.CalculateFuelRecursive(14);
			Assert.AreEqual(result, 2);

			result = FuelCounter.CalculateFuelRecursive(1969);
			Assert.AreEqual(result, 966);

			result = FuelCounter.CalculateFuelRecursive(100756);
			Assert.AreEqual(result, 50346);
		}
	}
}
