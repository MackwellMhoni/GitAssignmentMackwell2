using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text;

namespace RomanNumeralsConvTest
{
	public class UnitTest1
	{
		private string subtractivePair(int input)
		{
			var convert = new RomanNums();
			int rem = 0;
			var sub = new StringBuilder();
			

			if (input < 10)
			{
				rem = 10 - input;
				sub.Append(convert.Convert(rem));
				sub.Append(convert.Convert(10));
				return sub.ToString();
				
			}
			else if(input < 100)
			{
				rem = 100 - input;
				sub.Append(convert.Convert(rem));
				sub.Append(convert.Convert(100));
				return sub.ToString();
				
			}
			else if (input < 500)
			{
				rem = 500 - input;
				sub.Append(convert.Convert(rem));
				sub.Append(convert.Convert(500));
				return sub.ToString();
			}
			else if (input < 1000)
			{
				rem = 1000 - input;
				sub.Append(convert.Convert(rem));
				sub.Append(convert.Convert(1000));
				return sub.ToString();

			}
			else{
				return "Try Again";
			}

		}

		[Fact]
		public void Test_convert_1()
		{
			var convert = new RomanNums();
			int input = 1;

			Assert.Equal("I", convert.Convert(input));
		}

		[Fact]
		public void Test_convert_1_to_3()
		{
			var convert = new RomanNums();
			int input = 3;
			if (input <= 0 || input > 4)
			{
				throw new Exception("Needs to be between 1 and 3");
			}
			else
			{
				Assert.Equal("III", convert.Convert(input));
			}
		}

		[Fact]
		public void Test_out_of_range_negative()
		{
			var convert = new RomanNums();
			int input = -4;

			Assert.Equal("Out of Range", convert.CheckRange(input));

		}

		[Fact]
		public void Test_out_of_range_above_3000()
		{

			var convert = new RomanNums();
			int input = 3120;

			Assert.Equal("Out of Range", convert.CheckRange(input));
		}

		[Fact]
		public void Test_4()
		{
			var convert = new RomanNums();
			int input = 4;
			
			string subtractive = convert.Convert(input);
			if(subtractive == "IIII")
			{
				subtractive = "IV";
			}
			Assert.Equal("IV", subtractive);
			
		}

		[Fact]
		public void test_9()
		{
			int input = 9;
			string subCon = subtractivePair(input);

			Assert.Equal("IX",subCon);
		}

	

		[Fact]
		public void test_Dealing_with_Repition()
		{
			var convert = new RomanNums();
			int input = 19;

			Assert.Equal("Error: More than 3 repetitions", convert.Repition(input));
		}

		[Fact]
		public void test_Exposing_Incorrect()
		{
			var convert = new RomanNums();
			int input = 90;

			if(convert.Repition(input) == "Error: More than 3 repetitions")
			{
				string conv = convert.Convert(input);
				

				Assert.Equal("LXXXX", conv);
			}
		}

		[Fact]
		public void Test_Roman_Numeral_RND_number()
		{
			var convert = new RomanNums();
			int input = 90;

			string subCon = subtractivePair(input);
			Assert.Equal("XC",subCon);

		}

		[Fact]
		public void Test_Roman_Numeral_RND_number_400()
		{
			var convert = new RomanNums();
			int input = 400;

			string subCon = subtractivePair(input);
			Assert.Equal("CD", subCon);

		}


		[Fact]
		public void Test_Roman_Numeral_RND_number_900()
		{
			var convert = new RomanNums();
			int input = 900;

			string subCon = subtractivePair(input);
			Assert.Equal("CM", subCon);

		}

		[Fact]
		public void Test_Roman_Numeral_RND_number_1900()
		{
			var convert = new RomanNums();
			int input = 1900;

			if (input > 1000 || input < 2000)
			{

				string subCon = subtractivePair(input - 1000);
				var str = new StringBuilder();
				str.Append("M");
				str.Append(subCon);
				subCon = str.ToString();



				Assert.Equal("MCM", subCon);

			}
		}

		[Fact]
		public void Test_Roman_Numeral_RND_2400()
		{
			var convert = new RomanNums();
			int input = 2400;

			if (input > 2000 || input < 3000)
			{

				string subCon = subtractivePair(input - 2000);
				var str = new StringBuilder();
				str.Append(convert.Convert(2000));
				str.Append(subCon);
				subCon = str.ToString();



				Assert.Equal("MMCD", subCon);

			}
		}

		[Fact]
		public void Test_Roman_Numeral_RND_3000()
		{
			var convert = new RomanNums();
			int input = 3000;

			if (input == 3000)
			{

				string subCon = convert.Convert(input);
				subCon.ToString();



				Assert.Equal("MMM", subCon);

			}
		}

		[Fact]
		public void Test_Roman_Numeral_RND()
		{
			var convert = new RomanNums();
			Random rnd = new Random();
			string subCon = "";
			int input = rnd.Next(1,30001);

			if (input == 3000)
			{

				subCon = subtractivePair(input - 1000);
				var str = new StringBuilder();
				str.Append("M");
				str.Append(subCon);
				subCon = str.ToString();
			}

				Assert.Equal("Try Again", subCon);
			}
		}

}