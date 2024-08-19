using Leetcode75;

namespace LeetCode75.UnitTests;

public abstract partial class LeetCode75Tests
{
    public class KidsWithCandiesTests
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 5, 1, 3 }, 3, new bool[] { true, true, true, false, true })]
        [InlineData(new int[] { 4, 2, 1, 1, 2 }, 1, new bool[] { true, false, false, false, false })]
        [InlineData(new int[] { 12, 1, 12 }, 10, new bool[] { true, false, true })]
        [InlineData(new int[] { 5, 5, 5 }, 0, new bool[] { true, true, true })] // All kids have the same number of candies
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5, new bool[] { true, true, true, true, true })] // Extra candies make everyone the greatest
        [InlineData(new int[] { 1 }, 1, new bool[] { true })] // Single child scenario
        [InlineData(new int[] { 3, 9, 7, 8, 6 }, 0, new bool[] { false, true, false, false, false })] // No extra candies, check the initial greatest
        [InlineData(new int[] { 10, 5, 2, 8, 7 }, 3, new bool[] { true, false, false, true, true })] // Normal case with a mix of high and low numbers
        [InlineData(new int[] { 10, 20, 30, 40, 50 }, 0, new bool[] { false, false, false, false, true })] // Largest value at the end
        [InlineData(new int[] { 1, 2, 3, 2, 1 }, 2, new bool[] { true, true, true, true, true })] // Symmetric distribution with extra candies boosting all
        public void KidsWithCandies_ShouldReturnCorrectBooleanList(int[] candies, int extraCandies, bool[] expected)
        {
            var result = Questions.KidsWithCandies(candies, extraCandies);

            Assert.Equal(expected, result);
        }
    }
}