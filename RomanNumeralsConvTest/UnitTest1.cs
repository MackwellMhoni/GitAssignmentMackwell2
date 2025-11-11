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
	}
}