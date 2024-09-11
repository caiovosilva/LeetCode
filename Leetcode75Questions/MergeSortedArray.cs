namespace Leetcode75;

public abstract partial class Questions
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n) {
        var index1 = m - 1;  // Pointer for nums1
        var index2 = n - 1;  // Pointer for nums2
        var index = m + n - 1;  // Pointer for merging into nums1

        // Merge nums1 and nums2 in reverse order
        while (index1 >= 0 && index2 >= 0) {
            if (nums1[index1] > nums2[index2]) {
                nums1[index] = nums1[index1];
                index1--;
            } else {
                nums1[index] = nums2[index2];
                index2--;
            }
            index--;
        }

        // Copy remaining elements from nums2 (if any)
        while (index2 >= 0) {
            nums1[index] = nums2[index2];
            index--;
            index2--;
        }

        // No need to copy remaining nums1 elements as they are already in place
    }
}