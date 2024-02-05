namespace VowelCount;

public class Kata
{
    public static int GetVowelCount(string str)
    {
        return str.Count(c => "aeiou".Contains(c));
    }
}