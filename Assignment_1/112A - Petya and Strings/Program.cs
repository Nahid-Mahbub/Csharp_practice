string input1 = Console.ReadLine();
string input2 = Console.ReadLine();
char[] input1_array = input1.ToCharArray();
char[] input2_array = input2.ToCharArray();

for  (int i = 0; i < input1_array.Length; i++)
{
    if (input1_array[i] > 90)
    {
        input1_array[i] = (char)((int)input1_array[i] - 32) ;
    }
    if (input2_array[i] > 90)
    {
        input2_array[i] = (char)((int)input2_array[i] - 32);
    }
    Console.WriteLine(input1_array[i] + " " + input2_array[i]);
}

for  (int i = 0; i < input1_array.Length;i++)
{
    if(input1_array[i] != input2_array[i])
    {
        if (input1_array[i] > input2_array[i])
        {
            Console.WriteLine("1");
            return;
        }
        else if (input1_array[i] < input2_array[i])
        {
            Console.WriteLine("-1");
            return;
        }
    }
}
Console.WriteLine("0");
