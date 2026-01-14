int input = int.Parse(Console.ReadLine());
for (int i = 0; i < input; i++)
{
    int[] ints = Console.ReadLine()
        .Split(' ')
        .Select(int.Parse)
        .ToArray();

    if (ints[0] % ints[1] == 0)
    {
        Console.WriteLine('0');
    }
    else if(ints[0] < ints[1])
    {
        Console.WriteLine(ints[1] - ints[0]);
    }
    else
    {
        Console.WriteLine(ints[1] - (ints[0] % ints[1]));
    }
}