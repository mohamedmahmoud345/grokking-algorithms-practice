
// selection sort code 
int[] arr = [2, 1, 5, 3, 4];

var result = SelectionSort(arr);

Print(result);

static int[] SelectionSort(int[] arr)
{
    for (var i = 0; i < arr.Length - 1; i++)
    {
        int minIndex = i;
        for (var j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minIndex])
                minIndex = j;
        }
        if (minIndex != i)
            (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
    }
    return arr;
}

static void Print(int[] arr)
{
    foreach (var n in arr)
        System.Console.WriteLine(n);
}