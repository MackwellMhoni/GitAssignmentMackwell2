
using Microsoft.VisualBasic;
using System.Resources;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class RomanNums
{

	public static void Main()
	{
	
	}

	public string CheckRange(int input)
	{
		string RangeDetail = " ";

		if (input <= 0 || input > 3000)
		{
			RangeDetail = "Out of Range";
		}
		else
		{
			RangeDetail = "In Range";
		}
		return RangeDetail;
	}

	/*public string Con(int input)
	{
		var romanNumerals = new[]
{
				new { Value = 1000, Symbol = "M" },
				new { Value = 900,  Symbol = "CM" },
				new { Value = 500,  Symbol = "D" },
				new { Value = 400,  Symbol = "CD" },
				new { Value = 100,  Symbol = "C" },
				new { Value = 90,   Symbol = "XC" },
				new { Value = 50,   Symbol = "L" },
				new { Value = 40,   Symbol = "XL" },
				new { Value = 10,   Symbol = "X" },
				new { Value = 9,    Symbol = "IX" },
				new { Value = 5,    Symbol = "V" },
				new { Value = 4,    Symbol = "IV" },
				new { Value = 1,    Symbol = "I" }
			};

		var result = new StringBuilder();
		int remaining = input;

		foreach (var pair in romanNumerals)
		{
			while (remaining >= pair.Value)
			{
				result.Append(pair.Symbol);
				remaining -= pair.Value;
			}

		}

		return result.ToString();
	}*/


	public string Convert(int input)
	{
		
			var convers = new StringBuilder();
			var romanNumerals = new[]
			{
					new { Value = 1000, Symbol = "M" },
					new { Value = 500,  Symbol = "D" },
					new { Value = 100,  Symbol = "C" },
					new { Value = 50,   Symbol = "L" },
					new { Value = 10,   Symbol = "X" },
					new { Value = 5,    Symbol = "V" },
					new { Value = 1,    Symbol = "I" }
			};


			foreach (var pair in romanNumerals)
			{
				while (input >= pair.Value)
				{
					convers.Append(pair.Symbol);
					input -= pair.Value;
				}
			}
			return convers.ToString();
	}

	public string Repition(int input)
	{
		var romanNumerals = new[]
			{
					new { Value = 1000, Symbol = "M" },
					new { Value = 500,  Symbol = "D" },
					new { Value = 100,  Symbol = "C" },
					new { Value = 50,   Symbol = "L" },
					new { Value = 10,   Symbol = "X" },
					new { Value = 5,    Symbol = "V" },
					new { Value = 1,    Symbol = "I" }
			};

		var result = new StringBuilder();
		int remainingNum = input;

		foreach (var pair in romanNumerals)
		{
			while (remainingNum >= pair.Value)
			{
				string repeat = string.Concat(Enumerable.Repeat(pair.Symbol, 4));
				if (repeat.Contains(pair.Symbol + pair.Symbol + pair.Symbol + pair.Symbol))
				{
					return "Error: More than 3 repetitions";
				}
				else
				{
					result.Append(pair.Symbol);
					remainingNum -= pair.Value;
				}


			}
		}

		return result.ToString();
	}

}
   

