using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to count the vowels:");
        string input = Console.ReadLine();

        int vowelCount = CountVowels(input);
        Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
    }

    static int CountVowels(string str)
    {
        int count = 0;
        foreach (char c in str.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                count++;
            }
        }
        return count;
    }
}
