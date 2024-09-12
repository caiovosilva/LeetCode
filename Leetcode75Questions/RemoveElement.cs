namespace Leetcode75;

public abstract partial class Questions
{
    public static int RemoveElement(int[] nums, int val)
    {
        var k = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val) continue;

            nums[k] = nums[i];
            k++;
        }
        
        //
        // var valIndexes = new Queue<int>();
        // var nonValCount = 0;
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     if (nums[i] == val)
        //     {
        //         valIndexes.Enqueue(i);
        //     }
        //     else
        //     {
        //         nonValCount++;
        //     }
        // }
        //
        // for (var i = nums.Length - 1; i >= 0 && valIndexes.Count > 0; i--)
        // {
        //     if (nums[i] == val) continue;
        //     
        //     var valIndex = valIndexes.Dequeue();
        //     nums[valIndex] = nums[i];
        // }

        return k;
    }
}