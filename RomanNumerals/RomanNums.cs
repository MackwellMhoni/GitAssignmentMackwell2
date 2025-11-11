
using Microsoft.VisualBasic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class RomanNums
{
    public static void Main()
    {
		
	}

	public string Convert(int input)
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
		string conv = "";

		foreach (var pair in romanNumerals)
		{
			if (pair.Value == input)
			{
				conv = pair.Symbol;
			}
		}
		return conv;



	}
}
   

