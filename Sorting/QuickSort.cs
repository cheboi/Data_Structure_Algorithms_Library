namespace Algorithms.Sorting;

public static class QuickSort
{
    public static void Sort(Span<int> arr)
    {
        if (arr.Length <= 1) return;

        int pivot = arr[arr.Length / 2];
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            while (arr[left] < pivot) left++;
            while (arr[right] > pivot) right--;

            if (left <= right)
            {
                (arr[left], arr[right]) = (arr[right], arr[left]);
                left++;
                right--;
            }
        }

        Sort(arr[..(right + 1)]);
        Sort(arr[left..]);
    }
}
