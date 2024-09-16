namespace Leetcode75;

public abstract partial class Questions
{
    public static int MajorityElement(int[] nums)
    {
        var foundNumbers = new Dictionary<int, int>();
        var biggestCount = nums.Length > 1 ? 1 : 0;
        var mostRepeatedNumber = nums.FirstOrDefault();
        
        foreach (var num in nums)
        {
            if(foundNumbers.TryAdd(num, 1)) continue;

            if (!foundNumbers.TryGetValue(num, out var value)) continue;

            foundNumbers[num] += 1;
            if (foundNumbers[num] > biggestCount)
            {
                biggestCount = foundNumbers[num];
                mostRepeatedNumber = num;
            }
        }

        return mostRepeatedNumber;
    }
}