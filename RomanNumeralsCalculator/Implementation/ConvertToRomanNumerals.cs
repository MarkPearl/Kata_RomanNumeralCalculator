namespace RomanNumeralsCalculator.Implementation
{
	public class ConvertToRomanNumerals
	{
		public string ConvertFromSingles(string singles)
		{

			return ConvertFromSingles(singles.Length);
		}

		public string ConvertFromSingles(int numberOfI)
		{
			var result = string.Empty;

			for (var i = 0; i < numberOfI; i++)
			{
				result += "I";
				result = AttemptPatternTransform(result, "VIIII", RomanNumeral.Nine);		// 9
				result = AttemptPatternTransform(result, "IIII", RomanNumeral.Four);		// 4
				result = AttemptPatternTransform(result, "IXI", RomanNumeral.Ten);			// 10
				result = AttemptPatternTransform(result, "IVI", RomanNumeral.Five);			// 5
				result = AttemptPatternTransform(result, "XLX", RomanNumeral.Fifty);		// 50
				result = AttemptPatternTransform(result, "XXXX", RomanNumeral.Fourty);		// 40
				result = AttemptPatternTransform(result, "XCX", RomanNumeral.OneHundred);   // 100
				result = AttemptPatternTransform(result, "LXL", RomanNumeral.Ninety);		// 90
				result = AttemptPatternTransform(result, "CCCC", RomanNumeral.FourHundred); // 400
				result = AttemptPatternTransform(result, "CDC", RomanNumeral.FiveHundred);	// 500
				result = AttemptPatternTransform(result, "DCD", RomanNumeral.NineHundred);	// 900
				result = AttemptPatternTransform(result, "CMC", RomanNumeral.OneThousand);	// 1000
			}
			return result;
		}

		string AttemptPatternTransform(string input, string pattern1, string pattern2)
		{
			if (DoesNotEndWithPattern(input, pattern1)) return input;
			return ReplaceEndPattern1WithPattern2(input, pattern1, pattern2);
		}

		static string ReplaceEndPattern1WithPattern2(string input, string pattern1, string pattern2)
		{
			var result = input.Chop(pattern1.Length);
			result += pattern2;
			return result;
		}

		static bool DoesNotEndWithPattern(string input, string pattern)
		{
			return !input.EndsWith(pattern);
		}
	}
}
