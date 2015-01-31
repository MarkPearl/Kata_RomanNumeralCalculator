namespace RomanNumeralsCalculator
{
	public static class StringExtensions
	{
		public static string Chop(this string input, int numberOfCharacters)
		{
			return input.Substring(0, input.Length - numberOfCharacters);
		}
	}
}