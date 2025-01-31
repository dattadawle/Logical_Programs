using System.Text.RegularExpressions;

namespace _5_Remove_SpecialChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // Remove special characters
            string result = RemoveSpecialCharacters(input);

            Console.WriteLine("String after removing special characters:");
            Console.WriteLine(result);
        }
        static string RemoveSpecialCharacters(string str)
        {
            // Replace all non-alphanumeric characters with an empty string
            return Regex.Replace(str, "[^a-zA-Z0-9 ]", "");
        }
    }
}
