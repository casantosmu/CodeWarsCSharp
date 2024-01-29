using System.Text;

namespace SpinWords;

public class Kata
{
    private static string FormatWord(string word)
    {
        if (word.Length < 5)
            return word;

        var array = word.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }

    public static string SpinWords(string sentence)
    {
        var stringBuilder = new StringBuilder();
        var words = sentence.Split(" ");
        stringBuilder.Append(Kata.FormatWord(words[0]));
        for (var i = 1; i < words.Length; i++)
        {
            var word = words[i];
            stringBuilder.Append(' ').Append(Kata.FormatWord(word));
        }

        return stringBuilder.ToString();
    }
}