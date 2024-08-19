namespace Leetcode75;

public abstract partial class Questions
{
    public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        return candies.Select(t => t + extraCandies >= candies.Max()).ToList();
    }
}