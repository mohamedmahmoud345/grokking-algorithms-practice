

int[] arr = { 1, 2, 3, 4 };
var solution = new Solutions();

// 4.1 result
Console.WriteLine("Sum: " + solution.ReturnTotal(arr, 0));

// 4.2 result
Console.WriteLine("Count: " + solution.CountList(arr, 0));

// 4.3 result
Console.WriteLine("Max: " + solution.MaxNum(arr, 0));

// 4.4 result
Console.WriteLine("Binary Search (target=2): " + solution.BinarySearch(arr, 2, 0, arr.Length - 1));


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
