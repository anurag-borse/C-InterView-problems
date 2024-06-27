
using System;

public class Program
{
    public static int countSubCharacter(string array)
    {
        int count = 0;
        char[] array2 = array.ToCharArray();
        for (int i = 0; i < array2.Length; i++)
        {
            if (array2[i] == 'i')
            {
                if (array2[i + 1] == 's')
                {
                    count++;
                }

            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        string a = "This is my Interview";
        int product = countSubCharacter(a);
        Console.WriteLine(product);
    }
}