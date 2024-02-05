using VowelCount;

namespace Tests;

public class VowelCountTest
{
    [Fact]
    public void TestCase()
    {
        Assert.Equal(5, Kata.GetVowelCount("abracadabra"));
    }
}