namespace SortingAlgorithms.Algorithms;

public static class QuickSort
{
    public static void Sort(int[] array, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = array[leftIndex];

        while (i <= j)
        {
            while (array[i] < pivot)
                i++;
            
            while (array[j] > pivot)
                j--;

            if (i > j) continue;

            (array[i], array[j]) = (array[j], array[i]);
            i++;
            j--;
        }

        if (leftIndex < j)
            Sort(array, leftIndex, j);

        if (i < rightIndex)
            Sort(array, i, rightIndex);
    }
}