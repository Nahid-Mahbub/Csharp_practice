
string input = Console.ReadLine();

string[] parts = input.Split(' ');

int x = int.Parse(parts[0]);
int y = int.Parse(parts[1]);
int z = int.Parse(parts[2]);
int mod = (x % y);
string[] array = new string[z];

for (int i = 0; i < z; i++)
{
    while (mod < y)
    {
        mod = mod * 10;
    }
    array[i] = (mod / 7).ToString();
    mod = mod % y;
}
string result = string.Join("", array);
Console.WriteLine($"{x / y}.{result}");