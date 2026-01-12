HashSet<char> newSet = new HashSet<char>();
string input = Console.ReadLine();

input = input.Trim('{', '}');

foreach (char c in input)
{
    if (char.IsLetter(c))
    {
        newSet.Add(c);
    }
}

Console.WriteLine(newSet.Count);
