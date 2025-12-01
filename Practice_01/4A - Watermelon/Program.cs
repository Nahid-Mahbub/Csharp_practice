string line = Console.ReadLine();
int input = int.Parse(line);

if (input == 2)
{
    Console.WriteLine("NO");
}
else
{
    if (input % 2 == 0)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("NO");
    }
}