int[] arr = { 1, 2, 3, 4 };
var solution = new Solutions();

System.Console.WriteLine("-------------------- Divide & conquer exercises ----------------------");

// 4.1 result
Console.WriteLine("Sum: " + solution.ReturnTotal(arr, 0));

// 4.2 result
Console.WriteLine("Count: " + solution.CountList(arr, 0));

// 4.3 result
Console.WriteLine("Max: " + solution.MaxNum(arr, 0));

// 4.4 result
Console.WriteLine("Binary Search (target=2): " + solution.BinarySearch(arr, 2, 0, arr.Length - 1));

System.Console.WriteLine("-------------------- quick sort ----------------------");

// quick sort 
int[] arr2 = [2, 3, 4, 1, 5, 6];

var quickSort = new QuickSort();

var result = quickSort.Run(arr2, 0, arr2.Length - 1);

foreach (var n in result)
    System.Console.WriteLine(n);

public class Solutions
{
    // 4.1 Recursive sum of array elements
    public int ReturnTotal(int[] arr, int index)
    {
        if (index == arr.Length) // base case: end of array
            return 0;

        return arr[index] + ReturnTotal(arr, index + 1);
    }

    // 4.2 Recursive count of elements in array
    public int CountList(int[] arr, int index)
    {
        if (index == arr.Length) // base case: end of array
            return 0;

        return 1 + CountList(arr, index + 1);
    }

    // 4.3 Recursive maximum element in array
    public int MaxNum(int[] arr, int index)
    {
        if (index == arr.Length - 1) // base case: last element
            return arr[index];

        return Math.Max(arr[index], MaxNum(arr, index + 1));
    }

    // 4.4 Recursive binary search
    public int BinarySearch(int[] arr, int target, int left, int right)
    {
        if (left > right) // base case: not found
            return -1;

        int mid = (left + right) / 2;

        if (arr[mid] == target)
            return mid;
        else if (target < arr[mid])
            return BinarySearch(arr, target, left, mid - 1);
        else
            return BinarySearch(arr, target, mid + 1, right);
    }
}

public class QuickSort
{
    // Public method to sort an array using quicksort
    // left: starting index, right: ending index
    public int[] Run(int[] arr, int left, int right)
    {
        if (left < right)
        {
            // Get partition index where element is in correct position
            int pivotIndex = Partition(arr, left, right);

            // Recursively sort elements before and after partition
            Run(arr, left, pivotIndex - 1);   // Sort left side
            Run(arr, pivotIndex + 1, right);  // Sort right side
        }

        return arr;
    }

    // Partitions array and returns index of pivot element
    private int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];  // Choose rightmost element as pivot
        int i = left - 1;         // Index of smaller element

        // Traverse array from left to right-1
        for (var j = left; j < right; j++)
        {
            // If current element is smaller than or equal to pivot
            if (arr[j] <= pivot)
            {
                i++;  // Increment index of smaller element
                // Swap arr[i] and arr[j]
                (arr[j], arr[i]) = (arr[i], arr[j]);
            }
        }

        // Place pivot in correct position (after all smaller elements)
        (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);

        return i + 1;  // Return pivot's final position
    }
}
