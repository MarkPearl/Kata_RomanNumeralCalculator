using NUnit.Framework;
using RomanNumeralsCalculator.Implementation;

namespace RomanNumeralsCalculator.Tests
{
	[TestFixture]
	public class RomanNumeralCalculatorTests
	{
		[TestCase("I", "I", "II")]
		[TestCase("CL", "CLX", "CCCX")]
		[TestCase("X", "CMXC", "M")]
		public void AddTwoRomanNumeralsTogetherCorrectly(string numeral1, string numeral2, string expectedResult)
		{
			var calculator = new RomanNumeralCalculator(
				new ConvertToSingles(), 
				new ConvertToRomanNumerals());

			var result = calculator.Add(numeral1, numeral2);
			Assert.That(result, Is.EqualTo(expectedResult));
		}
	}
}