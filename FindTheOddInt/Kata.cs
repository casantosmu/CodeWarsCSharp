namespace FindTheOddInt;

public static class Kata
{
    public static int FindInt(int[] seq)
    {
        var odds = new HashSet<int>();
        foreach (var digit in seq)
            if (!odds.Remove(digit))
                odds.Add(digit);

        return odds.Single();
    }
}