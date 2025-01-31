namespace _4_Missing_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {0,1, 2, 3,5 };

            int sum = arr.Length * (arr.Length + 1) / 2;


            for (int i = 0; i < arr.Length; i++) {

                
                sum -= arr[i];
            }

            Console.WriteLine($"Missing Number is : {sum}");
        }
    }
}
