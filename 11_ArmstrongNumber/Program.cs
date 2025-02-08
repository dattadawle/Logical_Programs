namespace _11_ArmstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static bool IsArmstrong(int num)
            {
                int sum = 0, temp = num, digits = num.ToString().Length;
                while (temp > 0)
                {
                    int digit = temp % 10;
                    sum += (int)Math.Pow(digit, digits);
                    temp /= 10;
                }
                return sum == num;
            }

            static void Main()
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine(IsArmstrong(num) ? "Armstrong Number" : "Not an Armstrong Number");
            }
            Console.ReadKey();
        }
       
    }
}
