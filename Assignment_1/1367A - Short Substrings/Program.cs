int loop = int.Parse(Console.ReadLine());

for (int i = 0; i < loop; i++)
{
    string input = Console.ReadLine();
    for (int j = 0; j < input.Length; j++)
    {
        if(j % 2 == 0 && j != 0)
        {
            continue;
        }
        Console.Write(input[j]);
    }
    Console.WriteLine();
}