

// return the index of the number 

int[] nums = [1, 2, 3, 4, 5, 6, 7];

var result = BinarySearch(nums, 6);
System.Console.WriteLine(result);

static int? BinarySearch(int[] nums, int target)
{
    int low = 0;
    int high = nums.Length - 1;

    while (low <= high)
    {
        var mid = (low + high) / 2;

        if (nums[mid] == target)
            return mid;
        else if (nums[mid] < target)
            low = mid + 1;
        else
            high = mid - 1;
    }
    return null;
}