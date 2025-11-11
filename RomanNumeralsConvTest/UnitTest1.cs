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
		public void Test_convert_2_and_3()
		{
			var convert = new RomanNums();
			int input = 2;
			if (input <= 0 || input > 4)
			{
				throw new Exception("Needs to be between 1 and 3");
			}
			else
			{
				Assert.Equal("II", convert.Convert(input));
			}

		}
	}
}