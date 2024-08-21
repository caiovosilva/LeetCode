using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Leetcode75;

public abstract partial class Questions
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        var n = nums.Length;
        var result = new int[n];
        var leftProducts = new int[n];
        var rightProducts = new int[n];

        // Initialize the leftProducts and rightProducts arrays
        leftProducts[0] = 1;
        for (var i = 1; i < n; i++)
        {
            leftProducts[i] = leftProducts[i - 1] * nums[i - 1];
        }

        rightProducts[n - 1] = 1;
        for (var i = n - 2; i >= 0; i--)
        {
            rightProducts[i] = rightProducts[i + 1] * nums[i + 1];
        }

        // Calculate the result array by multiplying left and right products
        for (var i = 0; i < n; i++)
        {
            result[i] = leftProducts[i] * rightProducts[i];
        }

        return result;
    }
}