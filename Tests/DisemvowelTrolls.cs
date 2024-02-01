using DisemvowelTrolls;

namespace Tests;

public class DisemvowelTrollsTest
{
    [Theory]
    [InlineData("This website is for losers LOL!", "Ths wbst s fr lsrs LL!")]
    [InlineData("No offense but,\nYour writing is among the worst I've ever read",
        "N ffns bt,\nYr wrtng s mng th wrst 'v vr rd")]
    [InlineData("What are you, a communist?", "Wht r y,  cmmnst?")]
    public void ShouldRemoveAllVowels(string input, string expectedOutput)
    {
        Assert.Equal(expectedOutput, Kata.Disemvowel(input));
    }
}