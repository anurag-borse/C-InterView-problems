// Arun is a bus conductor.His ticket machine is printing numbers in reverse order due to a technical glitch. 
// As a programmer on the bus, you are asked to help him by creating a program to display the numbers correctly.

// Example:

// Input: 320
// Output: Number in reverse order: 23

// Input: 231
// Output Number in reverse order. 132

class Program
{
    public static void Main(string[] args)
    {
        int number1 = 320;
        int reversedNumber1 = ReverseNumber(number1);
        Console.WriteLine($"Number in reverse order: {reversedNumber1}");


        int number2 = 231;
        int reversedNumber2 = ReverseNumber(number2);
        Console.WriteLine($"Number in reverse order: {reversedNumber2}");
    }

    public static int ReverseNumber(int number)
    {
        char[] charArray = number.ToString().TrimEnd('0').ToCharArray();

        // logic 1
        // int left = 0;
        // int right = charArray.Length - 1;
        // while (left < right)
        // {
        //     char temp = charArray[left];
        //     charArray[left] = charArray[right];
        //     charArray[right] = temp;
        //     left++;
        //     right--;
        // }
        // return int.Parse(new string(charArray));

        //logic 2

        Array.Reverse(charArray);
        return int.Parse(new string(charArray));
    }
}