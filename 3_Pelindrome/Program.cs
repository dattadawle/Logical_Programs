namespace _3_Pelindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine($"'{input}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"'{input}' is not a palindrome.");
            }
        }

        static bool IsPalindrome(string text)
        {
            // Remove spaces and convert to lowercase
            string cleanedText = text.Replace(" ", "").ToLower();

            // Compare the string with its reverse
            char[] charArray = cleanedText.ToCharArray();
            Array.Reverse(charArray);
            string reversedText = new string(charArray);

            return cleanedText == reversedText;
        }
    }
}

