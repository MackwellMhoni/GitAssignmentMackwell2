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
			string RangeDetail = " ";

			if (input <= 0 || input > 3000)
			{
				RangeDetail = "Out of Range";
			}
			else
			{
				RangeDetail = "In Range";
			}

			Assert.Equal("Out of Range", RangeDetail);
		}

		[Fact]
		public void Test_out_of_range_above_3000()
		{

			var convert = new RomanNums();
			int input = 3120;
			Range(input);

		}

		private static void Range(int input)
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

			Assert.Equal("Out of Range", RangeDetail);
		}
	}
}