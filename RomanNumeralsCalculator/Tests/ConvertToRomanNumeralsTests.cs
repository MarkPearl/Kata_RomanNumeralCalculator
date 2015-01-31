using NUnit.Framework;
using RomanNumeralsCalculator.Implementation;

namespace RomanNumeralsCalculator.Tests
{
	[TestFixture]
	public class ConvertToRomanNumeralsTests
	{
		[TestCase("I","I")]
		[TestCase("II","II")]
		[TestCase("III","III")]
		[TestCase("IIII","IV")]
		[TestCase("IIIII","V")]
		[TestCase("IIIIII","VI")]
		[TestCase("IIIIIII","VII")]
		[TestCase("IIIIIIII","VIII")]
		[TestCase("IIIIIIIII","IX")]
		[TestCase("IIIIIIIIII","X")]
		[TestCase("IIIIIIIIIII","XI")]
		[TestCase("IIIIIIIIIIII","XII")]
		[TestCase("IIIIIIIIIIIII","XIII")]
		[TestCase("IIIIIIIIIIIIII","XIV")]
		[TestCase("IIIIIIIIIIIIIII","XV")]
		[TestCase("IIIIIIIIIIIIIIII","XVI")]
		[TestCase("IIIIIIIIIIIIIIIII","XVII")]
		[TestCase("IIIIIIIIIIIIIIIIII","XVIII")]
		[TestCase("IIIIIIIIIIIIIIIIIII","XIX")]
		public void ConvertSinglesToRomanNumerals(string input, string expected)
		{
			var convertToRomanNumerals = new ConvertToRomanNumerals();
			var converted = convertToRomanNumerals.ConvertFromSingles(input);
			Assert.That(converted, Is.EqualTo(expected));
		}

		[TestCase(10, "X")]
		[TestCase(29, "XXIX")]
		[TestCase(30, "XXX")]
		[TestCase(39, "XXXIX")]
		[TestCase(40, "XL")]
		[TestCase(41, "XLI")]
		[TestCase(44, "XLIV")]
		[TestCase(49, "XLIX")]
		[TestCase(50, "L")]
		[TestCase(51, "LI")]
		[TestCase(56, "LVI")]
		[TestCase(69, "LXIX")]
		[TestCase(89, "LXXXIX")]
		[TestCase(90, "XC")]
		[TestCase(99, "XCIX")]
		[TestCase(100, "C")]
		[TestCase(101, "CI")]
		[TestCase(104, "CIV")]
		[TestCase(105, "CV")]
		[TestCase(109, "CIX")]
		[TestCase(139, "CXXXIX")]
		[TestCase(140, "CXL")]
		[TestCase(150, "CL")]
		[TestCase(190, "CXC")]
		[TestCase(200, "CC")]
		[TestCase(250, "CCL")]
		[TestCase(399, "CCCXCIX")]
		[TestCase(400, "CD")]
		[TestCase(401, "CDI")]
		[TestCase(500, "D")]
		[TestCase(753, "DCCLIII")]
		[TestCase(900, "CM")]
		[TestCase(1000, "M")]
		[TestCase(4000, "MMMM")]
		[TestCase(4001, "MMMMI")]
		[TestCase(4999, "MMMMCMXCIX")]
		public void ConvertMultipleIToRomanNumerals(int repeatOfI, string expected)
		{
			var converted = new ConvertToRomanNumerals().ConvertFromSingles(repeatOfI);
			Assert.That(converted, Is.EqualTo(expected));
		}
	}
}