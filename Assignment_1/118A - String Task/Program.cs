String input = Console.ReadLine();

List<char> dynamicChar = new List<char>();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] <= 90)
    {
        dynamicChar.Add((char)((int)(input[i]+32)));
        continue;
    }
    dynamicChar.Add(input[i]);
}

int index = 0;
while (index < dynamicChar.Count)
{
    if (dynamicChar[index] == 'a' || dynamicChar[index] == 'e' || dynamicChar[index] == 'i' || dynamicChar[index] == 'o' || dynamicChar[index] == 'u' || dynamicChar[index] == 'y')
    {
        dynamicChar.RemoveAt(index);
        continue;
    }
    index++;
}
for (int i = 0; i < dynamicChar.Count; i++)
{
    Console.Write(dynamicChar[i]);
}
Console.WriteLine();
for (int i = 0; i < dynamicChar.Count; i++)
{
    Console.Write('.');
    Console.Write(dynamicChar[i]);
}
