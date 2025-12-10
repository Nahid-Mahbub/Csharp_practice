String input = Console.ReadLine();
List<int> num = new List<int>();
string[] slice = input.Split('+');

for (int i = 0; i < slice.Length; i++)
{
    num.Add(int.Parse(slice[i]));
}
num.Sort();

for (int i = 0; i < num.Count - 1; i++)
{
    Console.Write(num[i]);
    Console.Write('+');
}
Console.Write(num[num.Count - 1]);