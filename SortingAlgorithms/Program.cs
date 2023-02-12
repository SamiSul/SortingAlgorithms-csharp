using SortingAlgorithms.Algorithms;

// define array to sort
int[] array = { 73, 57, 49, 99, 133, 20, 1, 23 };

// call sorting method 
// BubbleSort.SortWithRecursion(array);
// SelectionSort.MySort(array);
HeapSort.MySort(array, array.Length - 1);
// print sorted list
foreach (var i in array)
{
    Console.Write(i + " ");
}