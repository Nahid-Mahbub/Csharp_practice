string input = Console.ReadLine();
int capitalCounter = 0;
int smallCounter = 0;
char[] arr = input.ToCharArray();

for  (int i = 0; i < input.Length; i++)
{
    if (input[i] < 'a')
    {
        capitalCounter++;
    }
    else
    {
        smallCounter++;
    }
}

if(capitalCounter > smallCounter)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 'Z')
        {
            arr[i] = (char)((int)(arr[i]) - 32);
        }
    }
}
else
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 'a')
        {
            arr[i] = (char)((int)(arr[i]) + 32);
        }
    }
        
}
string output = new string(arr);
Console.WriteLine(output);