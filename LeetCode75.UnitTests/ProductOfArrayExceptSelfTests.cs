using Leetcode75;

namespace LeetCode75.UnitTests;

public abstract partial class LeetCode75Tests
{
    public class ProductOfArrayExceptSelfTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
        [InlineData(new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 })]
        [InlineData(new int[] { 2, 3, 4, 5 }, new int[] { 60, 40, 30, 24 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 6, 3, 2 })]
        [InlineData(new int[] { 0, 0 }, new int[] { 0, 0 })]
        [InlineData(new int[] { 1, 0 }, new int[] { 0, 1 })]
        [InlineData(new int[] { 2, 3, 5, 7 }, new int[] { 105, 70, 42, 30 })]
        public void ProductExceptSelf_ShouldReturnCorrectResult(int[] nums, int[] expected)
        {
            // Act
            var result = Questions.ProductExceptSelf(nums);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}