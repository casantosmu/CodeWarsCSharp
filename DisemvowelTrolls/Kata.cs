namespace DisemvowelTrolls;

public class Kata
{
    private static readonly string[] Vowels = new string[] { "a", "e", "i", "o", "u" };

    public static string Disemvowel(string str)
    {
        return Vowels.Aggregate(str,
            (current, vowel) => current.Replace(vowel, string.Empty, StringComparison.CurrentCultureIgnoreCase));
    }
}