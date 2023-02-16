namespace SortingAlgorithms.Algorithms;

public static class MergeSort
{
    #region original

    // public static void Sort(int[] array, int left, int right)
    // {
    //     if (left >= right) return;
    //     var middle = left + (right - left) / 2;
    //     Sort(array, left, middle);
    //     Sort(array, middle + 1, right);
    //     Merge(array, left, middle, right);
    // }

    // private static void Merge(int[] array, int left, int middle, int right)
    // {
    //     var leftArrayLength = middle - left + 1;
    //     var rightArrayLength = right - middle;
    //     var leftTempArray = new int[leftArrayLength];
    //     var rightTempArray = new int[rightArrayLength];
    //
    //     int i, j;
    //     for (i = 0; i < leftArrayLength; ++i)
    //         leftTempArray[i] = array[left + i];
    //
    //     for (j = 0; j < rightArrayLength; ++j)
    //         rightTempArray[j] = array[middle + 1 + j];
    //
    //     i = 0;
    //     j = 0;
    //     var k = left;
    //     while (i < leftArrayLength && j < rightArrayLength)
    //     {
    //         if (leftTempArray[i] <= rightTempArray[j])
    //         {
    //             array[k++] = leftTempArray[i++];
    //         }
    //         else
    //         {
    //             array[k++] = rightTempArray[j++];
    //         }
    //     }
    //
    //     while (i < leftArrayLength) 
    //         array[k++] = leftTempArray[i++];
    //     
    //     while (j < rightArrayLength) 
    //         array[k++] = rightTempArray[j++];
    // }

    #endregion

    #region own copy

    // public static void MySort(int[] nums, int left, int right)
    // {
    //     // return if the array can't be subdivided anymore
    //     if (left >= right) return;
    //
    //     // if not, find the middle of the array. this will be needed for further subdivisions
    //     var middle = left + (right - left) / 2;
    //
    //     // divide the left side of the array/subarray
    //     MySort(nums, left, middle);
    //
    //     // divide the right side of the array/subarray
    //     MySort(nums, middle + 1, right);
    //
    //     // finally, merge the subarray
    //     MyMerge(nums, left, middle, right);
    // }
    //
    // private static void MyMerge(int[] nums, int left, int middle, int right)
    // {
    //     // get the length of the sub-arrays
    //     var leftArrLength = middle - left + 1;
    //     var rightArrLength = right - middle;
    //
    //     // temporary arrays to hold the sub-arrays
    //     var tempLeftArr = new int[leftArrLength];
    //     var tempRightArr = new int[rightArrLength];
    //
    //     // declare ints the will be used for the sub-arrays-traversing
    //     int i, j;
    //
    //     // populate the sub-arrays with their values from the original array
    //     for (i = 0; i < leftArrLength; i++)
    //         tempLeftArr[i] = nums[left + i];
    //
    //     for (j = 0; j < rightArrLength; j++)
    //         tempRightArr[j] = nums[middle + j + 1];
    //
    //     // reset i, j to now start merging
    //     // and declare k to keep track of the current element in the merged array
    //     i = 0;
    //     j = 0;
    //     var k = left;
    //
    //     // sort the sub-arrays and copy them to the merged array
    //     while (i < leftArrLength && j < rightArrLength)
    //     {
    //         if (tempLeftArr[i] <= tempRightArr[j])
    //             nums[k++] = tempLeftArr[i++];
    //
    //         else nums[k++] = tempRightArr[j++];
    //     }
    //
    //     // since the above while will stop when one of the emp arrays is finished
    //     // that means we have to copy over the value that was left in the other temp array
    //     while (i < leftArrLength)
    //         nums[k++] = tempLeftArr[i++];
    //
    //     while (j < rightArrLength)
    //         nums[k++] = tempRightArr[j++];
    // }

    #endregion

    #region own with one temp array

    public static void Sort(int[] nums, int left, int right)
    {
        if (left >= right) return;

        var middle = left + (right - left) / 2;
        Sort(nums, left, middle);
        Sort(nums, middle + 1, right);
        Merge(nums, left, middle, right);
    }

    private static void Merge(int[] nums, int left, int middle, int right)
    {
        var temp = new int[right - left + 1];
        var i = left;
        var j = middle + 1;
        var k = 0;

        while (i <= middle && j <= right)
        {
            if (nums[i] < nums[j])
                temp[k++] = nums[i++];

            else temp[k++] = nums[j++];
        }

        while (i <= middle)
            temp[k++] = nums[i++];

        while (j <= right)
            temp[k++] = nums[j++];

        for (var l = left; l <= right; l++)
            nums[l] = temp[l - left];
    }

    #endregion
}