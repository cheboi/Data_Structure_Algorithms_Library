using System;

class BinarySearch
{
    static int binarySearch(ReadOnlySpan<int> arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target) return mid;
            if (arr[mid] < target) left = mid + 1;
            else right = mid - 1;
        }
        return -1; 
    }

    static void Main()
    {
        int[] numbers = [1, 3, 5, 7, 9, 11, 15]; 
        int target = 7;

        int index = binarySearch(numbers, target);
        Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not found");
    }
}
