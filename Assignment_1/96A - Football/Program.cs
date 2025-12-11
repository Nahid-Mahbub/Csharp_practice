string input = Console.ReadLine();
var current = input[0];
var counter = 1;
for (int i = 1; i < input.Length; i++)
{
    if (current == input[i])
    {
        counter++;
    }
    else
    {
        counter = 1;
        current = input[i];
    }

    if (counter == 7)
    {
        Console.WriteLine("YES");
        return;
    }
}
Console.WriteLine("NO");