namespace Leetcode75;

public abstract partial class Questions
{
    public static int RemoveDuplicates(int[] nums)
    {
        var k = 0;
        var uniqueElements = new HashSet<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (uniqueElements.Add(nums[i]))
            {
                (nums[i], nums[k]) = (nums[k], nums[i]);
                k++;
            }
        }
        return k;
    }
}