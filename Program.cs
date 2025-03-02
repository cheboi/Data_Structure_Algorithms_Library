using System;
using Algorithms.Searching;
using Algorithms.Sorting;
using Algorithms.DynamicProgramming;

class Program
{

    static void Main()
    {
        int[] arr = [1, 3, 5, 7, 9, 11, 15];
        int target = 7;
        int index = BinarySearch.Search(arr, target);
        Console.WriteLine(index >= 0 ? $"Binary Search: Found at index {index}" : "Not found");

        //Quick Sort
        int[] numbers = [10, 7, 8, 9, 1, 5];
        Console.WriteLine("Before sorting: " + string.Join(", ", numbers));
        QuickSort.Sort(numbers);
        Console.WriteLine("After sorting: " + string.Join(", ", numbers));

        // fibo
        int fibNum = 10;
        Console.WriteLine($"Fibonacci({fibNum}): {Fibonacci.Compute(fibNum)}");
    }
}
