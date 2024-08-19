using Leetcode75;

namespace LeetCode75.UnitTests;

public abstract partial class LeetCode75Tests
{
    public class ReverseVowelsTests
    {
        [Theory]
        [InlineData("hello", "holle")]
        [InlineData("leetcode", "leotcede")]
        [InlineData("aA", "Aa")]
        [InlineData("racecar", "racecar")]
        [InlineData("aeiou", "uoiea")]
        [InlineData("AEIOU", "UOIEA")]
        [InlineData("bcdfg", "bcdfg")] // No vowels
        [InlineData("", "")] // Empty string
        [InlineData("E", "E")] // Single vowel
        public void ReverseVowels_ShouldReturnCorrectResult(string input, string expected)
        {
            // Act
            var result = Questions.ReverseVowels(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}