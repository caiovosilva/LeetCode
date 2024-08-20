using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Leetcode75;

public abstract partial class Questions
{
    public static string ReverseWords(string s)
    {
        s = s.Trim();
        var result = new StringBuilder();
        var wordStack = new Stack<string>();
        var singleWord = new StringBuilder();
        var whiteSpaceSkipped = false;
        for (int i = 0; i <= s.Length; i++)
        {
            if (i == s.Length)
            {
                wordStack.Push(singleWord.ToString());
                continue;
            }
            if (char.IsWhiteSpace(s[i]) && !whiteSpaceSkipped)
            {
                wordStack.Push(singleWord.ToString());
                singleWord.Clear();
                whiteSpaceSkipped = true;
            }
            else if(char.IsWhiteSpace(s[i]) && whiteSpaceSkipped)
            {
                continue;
            }
            else
            {
                singleWord.Append(s[i]);
                whiteSpaceSkipped = false;
            }
        }

        foreach (var word in wordStack.ToList())
        {
            result.Append(wordStack.Pop() + " ");
            
        }
        
        return result.ToString().Trim();
    }
}