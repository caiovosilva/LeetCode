using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Leetcode75;

public abstract partial class Questions
{
    public static string ReverseWords(string s)
    {
        var words = new List<string>();
        var word = new StringBuilder();
        var insideWord = false;

        foreach (var ch in s)
        {
            if (!char.IsWhiteSpace(ch))
            {
                word.Append(ch);
                insideWord = true;
            }
            else if (insideWord)
            {
                words.Add(word.ToString());
                word.Clear();
                insideWord = false;
            }
        }

        // Add the last word if there was no trailing space
        if (insideWord)
        {
            words.Add(word.ToString());
        }

        // Reverse the list of words and join them with a single space
        words.Reverse();
        return string.Join(" ", words);
    }
}