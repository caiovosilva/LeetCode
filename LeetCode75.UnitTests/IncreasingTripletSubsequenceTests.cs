using Leetcode75;

namespace LeetCode75.UnitTests;

public abstract partial class LeetCode75Tests
{
    public class IncreasingTripletSubsequenceTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, true)]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, false)]
        [InlineData(new int[] { 2, 1, 5, 0, 4, 6 }, true)]
        [InlineData(new int[] { 1, 1, -2, 6, -1, 5, 7 }, true)]
        [InlineData(new int[] { 5, 1, 5, 5, 2, 5, 4 }, true)]
        [InlineData(new int[] { 1, 2, 1, 2, 1, 3 }, true)]
        [InlineData(new int[] { 20, 100, 10, 12, 5, 13 }, true)]
        public void IncreasingTriplet_ShouldReturnCorrectResult(int[] nums, bool expected)
        {
            // Act
            var result = Questions.IncreasingTriplet(nums);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}