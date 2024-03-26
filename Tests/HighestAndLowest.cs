using HighestAndLowest;

namespace Tests;

public class HighestAndLowest
{
    public class HighestAndLowestTest
    {
        [Theory]
        [InlineData("8 3 -5 42 -1 0 0 -9 4 7 4 -4", "42 -9")]
        [InlineData("1 2 3", "3 1")]
        public void Test(string input, string expected)
        {
            var result = Kata.HighAndLow(input);
            Assert.Equal(expected, result);
        }
    }
}