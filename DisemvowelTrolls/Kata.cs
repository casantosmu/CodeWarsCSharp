namespace DisemvowelTrolls;

public static class Kata
{
    private static readonly string[] Vowels = { "a", "e", "i", "o", "u" };

    public static string Disemvowel(string str)
    {
        return Vowels.Aggregate(str,
            (current, vowel) => current.Replace(vowel, string.Empty, StringComparison.CurrentCultureIgnoreCase));
    }
}