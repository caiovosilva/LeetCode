using Leetcode75;

namespace LeetCode75.UnitTests;

public abstract partial class LeetCode75Tests
{
    public class GcdOfStringsTests
    {
        [Theory]
        [InlineData("ABCABC", "ABC", "ABC")]
        [InlineData("ABABAB", "ABAB", "AB")]
        [InlineData("LEET", "CODE", "")]
        [InlineData("ABCDEF", "ABC", "")]
        [InlineData("AAAA", "AA", "AA")]
        [InlineData("ABABAB", "ABABAB", "ABABAB")]
        public void GcdOfStrings_ShouldReturnGreatestCommonDivisorString(string str1, string str2, string expected)
        {
            var result = Questions.GcdOfStrings(str1, str2);

            Assert.Equal(expected, result);
        }
    }
}