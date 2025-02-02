namespace _9_ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number...");
            int num = int.Parse(Console.ReadLine()); // num=123

            int rev = 0;

            while (num > 0)
            {
                rev = rev * 10 + num % 10; //rev =3
                                           // rev=
                num /= 10;                   // num=12
            }
            Console.WriteLine("Reversed Number=" + rev);
            Console.ReadLine();
        }

    }
}
