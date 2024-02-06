using CreatePhoneNumber;

namespace Tests;

public class CreatePhoneNumberTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(123) 456-7890")]
    [InlineData(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, "(111) 111-1111")]
    public void FixedTest(int[] numbers, string expected)
    {
        Assert.Equal(expected, Kata.CreatePhoneNumber(numbers));
    }
}