using Leetcode75;

namespace LeetCode75.UnitTests;

public abstract partial class LeetCode75Tests
{
    public class CanPlaceFlowersTests
    {
        [Theory]
        [InlineData(new int[] { 1, 0, 0, 0, 1 }, 1, true)]
        [InlineData(new int[] { 1, 0, 0, 0, 1 }, 2, false)]
        [InlineData(new int[] { 0, 0, 1, 0, 0 }, 1, true)]
        [InlineData(new int[] { 0, 0, 1, 0, 0 }, 2, true)]
        [InlineData(new int[] { 0, 0, 0, 0, 0 }, 3, true)]
        [InlineData(new int[] { 1, 0, 1, 0, 1, 0, 1 }, 1, false)]
        [InlineData(new int[] { 1, 0, 0, 0, 0, 0, 1 }, 2, true)]
        public void CanPlaceFlowers_ShouldReturnCorrectResult(int[] flowerbed, int n, bool expected)
        {
            // Act
            var result = Questions.CanPlaceFlowers(flowerbed, n);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}