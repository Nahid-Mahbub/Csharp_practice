string input = Console.ReadLine();
int loop = int.Parse(input);
int counter = 0;
int max = 0;
for (int i = 0; i < loop; i++)
{
    string[] rowInput = Console.ReadLine().Split();
    int a = int.Parse(rowInput[0]);
    int b = int.Parse(rowInput[1]);
    counter = counter - a;
    counter = counter + b;
    if (max <  counter)
    {
        max = counter;
    }
}
Console.WriteLine(max);