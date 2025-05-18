Console.WriteLine("Enter input string");

string input = Console.ReadLine();

/*char[] charArr = input.ToCharArray();
int length = charArr.Length;
for (int i = length-1; i >=0; i--)
{
    Console.Write(charArr[i]);
}

Console.ReadLine();*/


//another way
char[] charArray = input.ToCharArray();

Array.Reverse(charArray);

Console.WriteLine(charArray);

