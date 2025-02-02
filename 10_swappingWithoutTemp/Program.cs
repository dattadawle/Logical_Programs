namespace _10_swappingWithoutTemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Numbers without swapping : a= {a} and b={b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Numbers with swapping : a= {a} and b={b}");

            Console.ReadKey();
        }
    }
}
