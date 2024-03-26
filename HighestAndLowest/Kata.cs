namespace HighestAndLowest;

public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        var parts = numbers.Split(" ").Select(int.Parse).ToArray();
        return $"{parts.Max()} {parts.Min()}";
    }
}