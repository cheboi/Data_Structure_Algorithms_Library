using System;
using Algorithms.Searching;

class Program
{

    static void Main()
    {
        int[] arr = [1, 3, 5, 7, 9, 11, 15];
        int target = 7;
        int index = BinarySearch.Search(arr, target);
        Console.WriteLine(index >= 0 ? $"Binary Search: Found at index {index}" : "Not found");
    }
}
