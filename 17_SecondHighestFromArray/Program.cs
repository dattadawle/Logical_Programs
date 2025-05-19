
//find the second highest number from array
int[] arr= new int[]{1,2,2,3,4,4,5,5,5,440};

int secondhigher=0;
int higher=0;

for (int i = 0; i< arr.Length; i++)
{
   
    if (arr[i] > secondhigher && arr[i] !=higher)
    {
        secondhigher = higher;
        higher = arr[i];
  
       
    }

    else if(arr[i] < secondhigher && arr[i] == secondhigher && higher == arr[i])
    {
        continue;
    }

}

Console.WriteLine($"second highest :{secondhigher}");

