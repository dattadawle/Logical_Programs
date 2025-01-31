namespace _6_DuplicateCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                FindDuplicateCharacters(input);
            Console.ReadKey();
        }

            static void FindDuplicateCharacters(string str)
            {
                Dictionary<char, int> charCount = new Dictionary<char, int>();

                foreach (char ch in str)
                {
                    if (charCount.ContainsKey(ch))
                        charCount[ch]++;
                    else
                        charCount[ch] = 1;
                }

                Console.WriteLine("Duplicate characters in the string:");
                foreach (var pair in charCount)
                {
                    if (pair.Value > 1)
                        Console.WriteLine($"Character: {pair.Key}, Count: {pair.Value}");
                }
            }
           
    }
}

