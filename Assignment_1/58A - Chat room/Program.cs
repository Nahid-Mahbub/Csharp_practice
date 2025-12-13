using System.Text;

int counter = 1;
string input = Console.ReadLine();
string hello = "";

for (int i = 0; i < input.Length; i++)
{
    if(input[i] ==  'h' || input[i] == 'e' || input[i] == 'l' || input[i] == 'o')
    {
        hello += input[i];
    }
}

foreach (char c in hello)
{
    if (c == 'h' && counter == 1)
    {
        counter++;
    }
    else if (c == 'e' && counter == 2)
    {
        counter++;
    }
    else if (c == 'l' && counter == 3)
    {
        counter++;
    }
    else if (c == 'l' && counter == 4)
    {
        counter++;
    }
    else if (c == 'o' && counter == 5)
    {
        Console.WriteLine("YES");
        return;
    }
}
Console.WriteLine("NO");