using System.Drawing;

string input = Console.ReadLine();
var stones = int.Parse(input);
var counter = 0;
string colors = Console.ReadLine();

for (int i = 0; i < stones - 1; i++)
{
    if (colors[i] == colors[i + 1])
    {
        counter++;
    }
}
Console.WriteLine(counter);