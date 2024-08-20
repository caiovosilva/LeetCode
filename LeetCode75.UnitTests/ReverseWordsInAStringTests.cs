using Leetcode75;

namespace LeetCode75.UnitTests;

public abstract partial class LeetCode75Tests
{
    public class ReverseWordsInAStringTests
    {
        [Theory]
        [InlineData("a b c", "c b a")]
        [InlineData("the sky is blue", "blue is sky the")]
        [InlineData("  hello world  ", "world hello")]
        [InlineData("a good   example", "example good a")]
        [InlineData("  Bob    Loves  Alice   ", "Alice Loves Bob")]
        [InlineData("Alice does not even like bob", "bob like even not does Alice")]
        [InlineData("", "")]
        [InlineData("    ", "")]
        [InlineData("word", "word")]
        public void ReverseWords_ShouldReturnCorrectResult(string input, string expected)
        {
            // Act
            var result = Questions.ReverseWords(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}