using NUnit.Framework;
using RomanNumeralsCalculator.Implementation;

namespace RomanNumeralsCalculator.Tests
{
	[TestFixture]
	public class ConvertRomanNumeralsToSinglesTests
	{
		[TestCase("I", 1)]
		[TestCase("III", 3)]
		[TestCase("IV", 4)]
		[TestCase("V", 5)]
		[TestCase("IX", 9)]
		[TestCase("X", 10)]
		[TestCase("XL", 40)]
		[TestCase("L", 50)]
		[TestCase("XC", 90)]
		[TestCase("C", 100)]
		[TestCase("CD", 400)]
		[TestCase("D", 500)]
		[TestCase("CM", 900)]
		[TestCase("M", 1000)]
		[TestCase("MMMMCMXXIX", 4929)]
		public void ConvertRomanNumeralToSingles(string romanNumeral, int expectedNumerOfI)
		{
			var sut = new ConvertToSingles();
			var result = sut.Convert(romanNumeral);
			Assert.That(result.Length, Is.EqualTo(expectedNumerOfI));
		}
	}
}