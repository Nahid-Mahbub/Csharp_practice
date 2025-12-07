string index = Console.ReadLine();
int n = int.Parse(index);
int answer = 0;
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    if (input == "++X")
    {
        answer++;
    }
    else if (input == "--X")
    {
        answer--;
    }
    else if (input == "X--")
    {
        answer--;
    }
    else if (input == "X++")
    {
        answer++;
    }
}
Console.WriteLine($"{answer}");