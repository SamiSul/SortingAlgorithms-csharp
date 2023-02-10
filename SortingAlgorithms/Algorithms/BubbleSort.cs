namespace SortingAlgorithms.Algorithms;

public static class BubbleSort
{
    public static void Sort(int[] NumArray)
    {
        var n = NumArray.Length;
        for (var i = 0; i < n - 1; i++)
        for (var j = 0; j < n - i - 1; j++)
            if (NumArray[j] > NumArray[j + 1])
            {
                (NumArray[j], NumArray[j + 1]) = (NumArray[j + 1], NumArray[j]);
            }
    }
    
    // I tried this first before looking at the answer... without recursion is probably better, though.
    public static void SortWithRecursion(int[] NumArray)
    {
        var n = NumArray.Length;
        for (var i = 0; i < n - 1; i++)
            if (NumArray[i] > NumArray[i + 1])
            {
                (NumArray[i], NumArray[i + 1]) = (NumArray[i + 1], NumArray[i]);
                Sort(NumArray);
            }
    }
}