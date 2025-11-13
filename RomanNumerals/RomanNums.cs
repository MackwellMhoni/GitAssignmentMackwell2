using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class RomanNums
{
	public class RomanNumeral
	{
		public int Value { get; set; }
		public string Symbol { get; set; }
	}

	private static readonly List<RomanNumeral> Numerals = new List<RomanNumeral>
	{
		new RomanNumeral { Value = 1000, Symbol = "M" },
		new RomanNumeral { Value = 900, Symbol = "CM" },
		new RomanNumeral { Value = 500, Symbol = "D" },
		new RomanNumeral { Value = 400, Symbol = "CD" },
		new RomanNumeral { Value = 100, Symbol = "C" },
		new RomanNumeral { Value = 90, Symbol = "XC" },
		new RomanNumeral { Value = 50, Symbol = "L" },
		new RomanNumeral { Value = 40, Symbol = "XL" },
		new RomanNumeral { Value = 10, Symbol = "X" },
		new RomanNumeral { Value = 9, Symbol = "IX" },
		new RomanNumeral { Value = 5, Symbol = "V" },
		new RomanNumeral { Value = 4, Symbol = "IV" },
		new RomanNumeral { Value = 1, Symbol = "I" }
	};

	public string CheckRange(int input)
	{
		if (input <= 0 || input > 3000)
			return "Out of Range";
		return "In Range";
	}

	public string Convert(int input)
	{
		if (input <= 0 || input > 3000)
			return "Out of Range";

		var result = new StringBuilder();

		foreach (var pair in Numerals)
		{
			while (input >= pair.Value)
			{
				result.Append(pair.Symbol);
				input -= pair.Value;
			}
		}

		return result.ToString();
	}

	public string CheckRepetition(string roman)
	{
		if (roman.Contains("IIII") || roman.Contains("XXXX") || roman.Contains("CCCC") || roman.Contains("MMMM"))
			return "Error: More than 3 repetitions";

		return "Valid";
	}

	public static void Main()
	{
		var converter = new RomanNums();

		Console.WriteLine(converter.CheckRange(2025));
		Console.WriteLine(converter.Convert(2025));
		Console.WriteLine(converter.CheckRepetition(converter.Convert(2025)));
	}
}
