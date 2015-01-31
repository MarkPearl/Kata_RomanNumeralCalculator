namespace RomanNumeralsCalculator.Implementation
{
	public class ConvertToSingles
	{
		const char SingleCharacter = 'I';

		public string Convert(string romanNumeral)
		{
			var result = romanNumeral;
			result = result.Replace(RomanNumeral.Four, GenerateI(4));
			result = result.Replace(RomanNumeral.Five, GenerateI(5));
			result = result.Replace(RomanNumeral.Nine, GenerateI(9));
			result = result.Replace(RomanNumeral.Fourty, GenerateI(40));
			result = result.Replace(RomanNumeral.Ninety, GenerateI(90));
			result = result.Replace(RomanNumeral.FourHundred, GenerateI(400));
			result = result.Replace(RomanNumeral.NineHundred, GenerateI(900));
			result = result.Replace(RomanNumeral.Ten, GenerateI(10));
			result = result.Replace(RomanNumeral.OneHundred, GenerateI(100));
			result = result.Replace(RomanNumeral.FiveHundred, GenerateI(500));
			result = result.Replace(RomanNumeral.Fifty, GenerateI(50));
			result = result.Replace(RomanNumeral.OneThousand, GenerateI(1000));
			return result;
		}

		static string GenerateI(int numberOfI)
		{
			var result = string.Empty;
			for (var i = 0; i < numberOfI; i++)
			{
				result += SingleCharacter;
			}
			return result;
		}
	}
}