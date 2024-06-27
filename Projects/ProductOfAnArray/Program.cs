

// Question

// Product of an Anay

// You are given an integer array A of size N.
// Your ytask is to Find and return async Integer value representing the product of 
// all the elements in the array


// Input Specification:

// input1: An integer array A

// Input2: An integer value N representing the size of array

// Output Specification:
// return async integer value representing the product of all the elements in the array

// Example 1:
// input1: (2, 4, 6, 8)

// Output: 120



using System;

public class Program
{
    public static int getProduct(int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 5 };
        int product = getProduct(array);
        Console.WriteLine(product);
    }
}