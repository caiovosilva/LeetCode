using System.Numerics;

namespace Leetcode75;

public abstract partial class Questions
{
    public static string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1) 
            return string.Empty;
        
        var lengthOfCommonString = BigInteger.GreatestCommonDivisor(str1.Length, str2.Length);
        return str1[..(int)lengthOfCommonString]; // same as str1.Substring(0, lengthOfCommonString);
    }
}