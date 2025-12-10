using System.Runtime.CompilerServices;

string input = Console.ReadLine();
int index = int.Parse(input);
string[] Loop_input = new string[index];
//Console.WriteLine(index);
//Console.WriteLine(index.GetType());

for (int i = 0; i < index; i++)
{
    Loop_input[i] = Console.ReadLine();
}
for (int i = 0; i < index; i++)
{
    if (Loop_input[i].Length > 10)
    {
        Console.WriteLine($"{Loop_input[i][0]}{Loop_input[i].Length - 2}{Loop_input[i][Loop_input[i].Length - 1]}");
    }
    else
    {
        Console.WriteLine($"{Loop_input[i]}");
    }
}