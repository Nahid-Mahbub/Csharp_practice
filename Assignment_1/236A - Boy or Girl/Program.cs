string input = Console.ReadLine();
var set = new HashSet<char>();

for  (int i = 0; i < input.Length; i++)
{
    set.Add(input[i]);
}
if(set.Count % 2 == 0)
{
    Console.WriteLine("CHAT WITH HER!");
}
else
{
    Console.WriteLine("IGNORE HIM!");
}