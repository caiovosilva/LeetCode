namespace Leetcode75;

public abstract partial class Questions
{
    public static bool CanPlaceFlowers(int[] flowerbed, int n) {
        for (var i = 0; i < flowerbed.Length && n > 0; i++)
        {
            if(IsLeftZero(flowerbed, i) && IsRightZero(flowerbed, i) && flowerbed[i] == 0)
            {
                flowerbed[i] = 1;
                n--;
            }
        }
        return n <= 0;
    }
    
    private static bool IsLeftZero(int[] flowerbed, int i)
    {
        return i == 0 || flowerbed[i - 1] == 0;
    }
    
    private static bool IsRightZero(int[] flowerbed, int i)
    {
        return i == flowerbed.Length - 1 || flowerbed[i + 1] == 0;
    }
}