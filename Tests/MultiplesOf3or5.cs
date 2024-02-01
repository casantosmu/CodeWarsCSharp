using MultiplesOf3or5;

namespace Tests;

public class MultiplesOf3Or5Test
{
    [Theory]
    [InlineData(23, 10)]
    [InlineData(78, 20)]
    [InlineData(9168, 200)]
    [InlineData(0, 0)]
    public void SampleTests(int expected, int input)
    {
        Assert.Equal(expected, Kata.Solution(input));
    }
}