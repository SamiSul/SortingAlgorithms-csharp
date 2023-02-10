namespace SortingAlgorithms.Algorithms;

public static class BubbleSort
{
    public static void Sort(int[] nums)
    {
        var n = nums.Length;
        for (var i = 0; i < n - 1; i++)
        for (var j = 0; j < n - i - 1; j++)
            if (nums[j] > nums[j + 1])
            {
                (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
            }
    }
    
    // I tried this first before looking at the answer... without recursion is probably better, though.
    public static void SortWithRecursion(int[] nums)
    {
        var n = nums.Length;
        for (var i = 0; i < n - 1; i++)
            if (nums[i] > nums[i + 1])
            {
                (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
                Sort(nums);
            }
    }
}