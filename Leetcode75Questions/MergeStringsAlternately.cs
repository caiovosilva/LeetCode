namespace Leetcode75;

public abstract partial class Questions
{
    public static string MergeAlternately(string word1, string word2)
    {
        var result = string.Empty;
        var longestString = Math.Max(word1.Length, word2.Length);
        for (var i = 0; i < longestString; i++)
        {
            if(word1.ElementAtOrDefault(i) != default)
            {
                result += word1[i];
            }
            if(word2.ElementAtOrDefault(i) != default)
            {
                result += word2[i];
            }
        }

        return result;
    }
}