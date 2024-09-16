namespace Leetcode75;

public abstract partial class Questions
{
    public static bool IncreasingTriplet(int[] nums) {
        var result = false;
        for (var i = 1; i < nums.Length; i++)
        {
            var leftItem = nums.Where((item, index) => item < nums[i] && index < i);
            var rightItem = nums.Where((item, index) => item > nums[i] && index > i);

            if (leftItem.Any() && rightItem.Any())
            {
                result = true;
                break;
            }
        }

        return result;
    }
}