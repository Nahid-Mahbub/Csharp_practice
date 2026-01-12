string input = Console.ReadLine();
foreach (char c in input)
{
    if (c == 'H' || c == 'Q' || c == '9')
    {
        Console.WriteLine("YES");
        return;
    }
}
Console.WriteLine("NO");