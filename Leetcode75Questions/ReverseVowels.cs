using System.Text;

namespace Leetcode75;

public abstract partial class Questions
{
    public static string ReverseVowels(string s) {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var vowelStack = new Stack<char>(s.Where(c => vowels.Contains(c)));
        var result = new StringBuilder(s.Length);

        foreach (var t in s)
        {
            if (vowels.Contains(t))
            {
                result.Append(vowelStack.Pop());
            }
            else
            {
                result.Append(t);
            }
        }

        return result.ToString();
    }
}