using SortingAlgorithms.Algorithms;

// define array to sort
int[] array = { 73, 57, 49, 99, 133, 20, 1 };

// call sorting method 
BubbleSort.SortWithRecursion(array);

// print sorted list
foreach (var i in array)
{
    Console.Write(i+ " ");
}