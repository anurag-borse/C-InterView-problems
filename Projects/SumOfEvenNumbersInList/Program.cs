using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sumOfEvens = SumOfEvenNumbers(numbers);
        Console.WriteLine($"The sum of even numbers in the list is: {sumOfEvens}");
    }

    static int SumOfEvenNumbers(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                sum += number;
            }
        }
        return sum;
    }
}
