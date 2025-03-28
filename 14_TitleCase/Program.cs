using System;
using System.Globalization;

class Program
{
    static string ToTitleCase(string str)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(str.ToLower());
    }

    static void Main()
    {
        Console.WriteLine(ToTitleCase("hello world"));  // Output: "Hello World"
    }
}
