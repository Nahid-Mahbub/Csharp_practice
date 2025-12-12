string[] input = Console.ReadLine().Split();

int val = int.Parse(input[0]);
int k = int.Parse(input[1]);

for (int i = 0; i < k; i++)
{
    if (val % 10 != 0)
    {
        val--;
    }
    else
    {
        val /= 10;
    }
}
Console.WriteLine(val);