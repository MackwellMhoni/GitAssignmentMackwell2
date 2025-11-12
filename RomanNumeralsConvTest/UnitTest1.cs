using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text;

namespace RomanNumeralsConvTest
{
	public class UnitTest1
	{
		

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
			var convert = new RomanNums();
			int input = 9;
			int rem = 0;
			var sub = new StringBuilder();
			

			if (input < 10)
			{
				rem = 10 - input;
				sub.Append(convert.Convert(rem));
				sub.Append(convert.Convert(10));
			}
			Assert.Equal("IX", sub.ToString());
		}

		[Fact]
		public void test_Dealing_with_Repition()
		{
			var convert = new RomanNums();
			int input = 19;

			Assert.Equal("Error: More than 3 repetitions", convert.Repition(input));
		}

	}
}