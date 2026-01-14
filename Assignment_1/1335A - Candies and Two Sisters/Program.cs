int loop = int.Parse(Console.ReadLine());

for (int i = 0; i < loop; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num < 3)
    {
        Console.WriteLine('0');
    }
    else
    {
        if (num % 2 == 0)
        {
            Console.WriteLine(num / 2 - 1);
        }
        else
        {
            Console.WriteLine(num / 2);
        }
    }
}