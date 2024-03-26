namespace VowelCount;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        return str.Count(c => "aeiou".Contains(c));
    }
}