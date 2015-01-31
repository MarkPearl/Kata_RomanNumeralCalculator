namespace RomanNumeralsCalculator.Implementation
{
	public class RomanNumeralCalculator
	{
		readonly ConvertToSingles _convertToSingles;
		readonly ConvertToRomanNumerals _convertToRomanNumerals;

		public RomanNumeralCalculator(
			ConvertToSingles convertToSingles,
			ConvertToRomanNumerals convertToRomanNumerals)
		{
			_convertToSingles = convertToSingles;
			_convertToRomanNumerals = convertToRomanNumerals;
		}

		public string Add(string numeral1, string numeral2)
		{
			var numeral1AsSingles = _convertToSingles.Convert(numeral1);
			var numeral2AsSingles = _convertToSingles.Convert(numeral2);
			var sumOfSingles = numeral1AsSingles + numeral2AsSingles;
			return _convertToRomanNumerals.ConvertFromSingles(sumOfSingles);
		}
	}
}