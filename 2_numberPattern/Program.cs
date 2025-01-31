namespace _2_numberPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int length = 4;

             for (int i = 1; i <= length; i++)
             {
                 for (int j = i; j <= length; j++)
                 {
                     Console.Write($" ");
                 }

                 int k = i;
                 while (k >= 1)
                 {
                     Console.Write(k);
                     k--;
                 }
                 Console.WriteLine();

 */


            // second Way
            // 

            int rows = 5;

            for (int i = 1; i <= rows; i++) { 
                int temp = i;
                for(int j=1; j <= rows; j++)
                {
                    if (rows-j-i+1>0) {


                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write($"{temp--} ");
                    }
                
            }
                Console.WriteLine();





            }
          
        }
    }
}
