using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

Console.ReadLine();

int[] array = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

int maxIndex = Array.IndexOf(array, array.Max());
int minIndex = 0;
for (int i = array.Length - 1; i >= 0; i--)
{
    if (array[i] == array.Min())
    {
        minIndex = i;
        break;
    }
}

if (maxIndex < minIndex)
{
    Console.WriteLine((maxIndex - 0) + (array.Length-1 - minIndex));
}
else
{
    Console.WriteLine((maxIndex - 0) + array.Length - 2 - minIndex);
}