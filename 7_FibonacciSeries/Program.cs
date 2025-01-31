namespace _7_FibonacciSeries
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of terms: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:");

            int first = 0, second = 1, next;

            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                    next = i;
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                }

                Console.Write(next + " ");
            }
        }
    }

}
