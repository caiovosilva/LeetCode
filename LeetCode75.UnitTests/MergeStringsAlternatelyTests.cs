using Leetcode75;

namespace LeetCode75.UnitTests;

public abstract partial class LeetCode75Tests
{
    public class MergeAlternatelyTests
    {
        [Theory]
        [InlineData("abc", "pqr", "apbqcr")]
        [InlineData("ab", "pqrs", "apbqrs")]
        [InlineData("abcd", "pq", "apbqcd")]
        [InlineData("", "abc", "abc")]
        [InlineData("abc", "", "abc")]
        [InlineData("", "", "")]
        public void MergeAlternately_ShouldReturnMergedString(string word1, string word2, string expected)
        {
            var result = Questions.MergeAlternately(word1, word2);

            Assert.Equal(expected, result);
        }
    }
}