using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int target = 7;

        int index = BinarySearch(array, target);

        if (index != -1)
        {
            Console.WriteLine($"Element {target} found at index {index}.");
        }
        else
        {
            Console.WriteLine($"Element {target} not found in the array.");
        }
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;

            if (array[middle] == target)
            {
                return middle;
            }
            else if (array[middle] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1; // Target not found
    }
}
