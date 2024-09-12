namespace Leetcode75;

public abstract partial class Questions
{
    public static void MoveZeroes(int[] nums) {
        var zeroIndex = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) continue;

            (nums[i], nums[zeroIndex]) = (nums[zeroIndex], nums[i]);
            zeroIndex++;
        }
        
        // var valIndexes = new Queue<int>();
        // var zerosCount = 0;
        //
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     if (nums[i] == 0)
        //     {
        //         valIndexes.Enqueue(i);
        //         zerosCount++;
        //     }
        //     else if (valIndexes.Count > 0)
        //     {
        //         var valIndex = valIndexes.Dequeue();
        //         nums[valIndex] = nums[i];
        //         valIndexes.Enqueue(i);
        //         nums[i] = 0;
        //     }
        // }
    }
}