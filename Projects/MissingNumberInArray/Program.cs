using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 4, 6, 3, 7, 8 }; // 1st n natural numbers
        int[] arr2 = { 0, 1, 2, 4, 6, 3, 7, 8 }; // n number from 0 to n

        int missingNaturalNumber = FindMissingNaturalNumber(arr);
        int missingNumber = FindMissingNumber(arr2);

        Console.WriteLine($"Missing number in Array: {missingNaturalNumber}");
        Console.WriteLine($"Missing number in Array: {missingNumber}");

    }

    static int FindMissingNaturalNumber(int[] array)
    {
        int length = array.Length + 1; // Length of the array if no number were missing
        int totalSum = length * (length + 1) / 2; // Sum of the first n natural numbers
        int arraySum = 0;

        foreach (int num in array)
        {
            arraySum += num;
        }
        int n = totalSum - arraySum;
        return n;
    }

    static int FindMissingNumber(int[] array)
    {
        int length = array.Length; // The number of elements in the array
        int n = length; // As the array includes numbers from 0 to n, the total count is length

        int totalSum = n * (n + 1) / 2; // Sum of the first n natural numbers including 0
        int arraySum = 0;

        foreach (int num in array)
        {
            arraySum += num;
        }

        return totalSum - arraySum;
    }
}
