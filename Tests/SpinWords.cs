namespace Tests;

using global::SpinWords;

public class SpinWords
{
    [Theory]
    [InlineData("Hey fellow warriors", "Hey wollef sroirraw")]
    [InlineData("This is a test", "This is a test")]
    [InlineData("This is another test", "This is rehtona test")]
    public void TestTextTransformation(string input, string expected)
    {
        var result = Kata.SpinWords(input);
        Assert.Equal(expected, result);
    }
}