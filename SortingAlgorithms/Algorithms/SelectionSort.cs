namespace SortingAlgorithms.Algorithms;

public static class SelectionSort
{
    public static void Sort(int[] nums)
    {
        var n = nums.Length;
        for (var i = 0; i < n - 1; i++)
        {
            var smallest = i;
            for (var j = i + 1; j < n; j++)
            {
                if (nums[j] < nums[smallest])
                {
                    smallest = j;
                }
            }

            (nums[smallest], nums[i]) = (nums[i], nums[smallest]);
        }
    }

    public static void MySort(int[] nums)
    {
        var n = nums.Length;
        for (var i = 0; i < n - 1; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                if (nums[j] < nums[i])
                {
                    (nums[j], nums[i]) = (nums[i], nums[j]);
                }
            }
        }
    }
}