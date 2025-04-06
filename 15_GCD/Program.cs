using System;

class GCDExample
{
    static int GCD(int a, int b)
    {
        return (b == 0) ? a : GCD(b, a % b);
    }

    static void Main()
    {
        Console.Write("Enter two numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("GCD: " + GCD(a, b));
    }
}
