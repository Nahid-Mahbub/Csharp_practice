int loop = int.Parse(Console.ReadLine());
for (int i = 0; i < loop; i++)
{
    int[] array = new int[3];
    string input = Console.ReadLine();
    string[] slice = input.Split(" ");
    array[0] = int.Parse(slice[0]);
    array[1] = int.Parse(slice[1]);
    array[2] = int.Parse(slice[2]);
    Array.Sort(array);
    if (array[0] +  array[1] == array[2])
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}