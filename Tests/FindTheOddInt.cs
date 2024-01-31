using FindTheOddInt;

namespace Tests;

public class FindTheOddIntTest
{
    [Theory]
    [InlineData(new[] { 7 }, 7)]
    [InlineData(new[] { 0 }, 0)]
    [InlineData(new[] { 1, 1, 2 }, 2)]
    [InlineData(new[] { 0, 1, 0, 1, 0 }, 0)]
    [InlineData(new[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 }, 4)]
    public void TestOddOccurrence(int[] input, int expected)
    {
        var result = Kata.FindInt(input);
        Assert.Equal(expected, result);
    }
}