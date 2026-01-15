int loop = int.Parse(Console.ReadLine());

for (int i = 0; i < loop; i++)
{
    int loop2 = int.Parse(Console.ReadLine());
    int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    Array.Sort(array);
    bool flag = false;
    for (int j = 1; j < array.Length; j++)
    {
        if (Math.Abs(array[j] - array[j-1]) > 1)
        {
            Console.WriteLine("No");
            flag = true;
            break;
        }
    }
    if (flag == false)
        Console.WriteLine("Yes");
}