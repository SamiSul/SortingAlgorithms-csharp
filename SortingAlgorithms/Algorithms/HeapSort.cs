namespace SortingAlgorithms.Algorithms;

public static class HeapSort
{
    public static void Sort(int[] nums, int size)
    {
        if (size == 0) return;

        // item / 2 - 1 gets the parent of the node
        // we build the max heap
        for (var i = size / 2 - 1; i >= 0; i--)
        {
            Heapify(nums, size, i);
        }

        for (var i = size; i >= 0; i--)
        {
            // we place the root element at the end of where we are
            // and rebuild the max heap
            (nums[0], nums[i]) = (nums[i], nums[0]);
            Heapify(nums, i, 0);
        }
    }

    static void Heapify(int[] array, int size, int index)
    {
        var largestIndex = index;
        var leftChild = 2 * index + 1;
        var rightChild = 2 * index + 2;

        if (leftChild < size && array[leftChild] > array[largestIndex])
        {
            largestIndex = leftChild;
        }

        if (rightChild < size && array[rightChild] > array[largestIndex])
        {
            largestIndex = rightChild;
        }

        if (largestIndex == index) return;
        (array[index], array[largestIndex]) = (array[largestIndex], array[index]);

        Heapify(array, size, largestIndex);
    }

    // My try without looking
    public static void MySort(int[] nums, int size)
    {
        // return if array has 1 element
        if (size == 0) return;

        // build max heap. start with the last non-leaf element
        for (var i = size / 2 - 1; i >= 0; i--) Heapify(nums, size, i);

        for (var i = size; i >= 0; i--)
        {
            // swap first (largest) and last element in the array
            (nums[i], nums[0]) = (nums[0], nums[i]);
            //rebuild the max heap, excluding the last element (after swapping)
            MyHeapify(nums, i, 0);
        }
    }

    static void MyHeapify(int[] nums, int size, int index)
    {
        var largest = index;
        var leftChild = index * 2 + 1;
        var rightChild = index * 2 + 2;

        // check if the children of the node have a bigger value
        // and swap them if so
        if (leftChild < size && nums[leftChild] > nums[largest]) largest = leftChild;
        if (rightChild < size && nums[rightChild] > nums[largest]) largest = rightChild;
        
        // or return if not
        if (largest == index) return;
        
        // swap parent and child
        (nums[largest], nums[index]) = (nums[index], nums[largest]);
        
        // build max heap starting with the child
        MyHeapify(nums,size, largest);
    }
}