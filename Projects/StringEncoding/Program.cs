// String Encoding 
// GoldmanSachs

// Encode a given string by collapsing consecutive instances of a single character inte 
// two pieces of information the number of instances and the character. 
//Note that even single characters should be run length encoded. 
//If the string is empty, return an empty string.
// Your implementation should work on all alphanumeric characters.

// Complete the colipaseinput function which takes a string input 
// as a parameter and returns the compressed string


// Sample input : GGGGGxxxxxxxxxxxxT

// Sample Output : 5G12x1T

// Explanation

// There are 5 G characters then there are 12'x's then there is 1 T



using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        string input = "GGGGGxxxxxxxxxxxxT";
        string compressedString = CollapseInput(input);
        Console.WriteLine(compressedString);
    }

    public static string CollapseInput(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        StringBuilder compressed = new StringBuilder();
        int count = 1;
        char currentChar = input[0];

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == currentChar)
            {
                count++;
            }
            else
            {
                compressed.Append(count).Append(currentChar);
                currentChar = input[i];
                count = 1;
            }
        }

        // Append the last set of characters
        compressed.Append(count).Append(currentChar);

        return compressed.ToString();
    }
}
