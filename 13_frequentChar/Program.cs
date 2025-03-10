using System;
using System.Linq;

class Program
{
    static char MostFrequentChar(string str)
    {
        return str.GroupBy(c => c)
                  .OrderByDescending(g => g.Count())
                  .First().Key;
    }

    static void Main()
    {
        Console.WriteLine(MostFrequentChar("hello"));  // Output: 'l'
    }
}
