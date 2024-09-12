namespace Leetcode75;

public abstract partial class Questions
{
    public static int[] ApplyOperations(int[] nums) {
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] != nums[i + 1]) continue;
            
            nums[i] *= 2;
            nums[i + 1] = 0;
        }

        var zeroIndex = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) continue;

            (nums[i], nums[zeroIndex]) = (nums[zeroIndex], nums[i]);
            zeroIndex++;
        }

        return nums;
    }
}