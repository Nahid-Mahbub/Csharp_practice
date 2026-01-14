int loop = int.Parse(Console.ReadLine());

for (int i = 0; i < loop; i++)
{
    int num = int.Parse(Console.ReadLine());
    if ((num / 2) % 2 == 0)
    {
        int sumEven = 0;
        int sumOdd = 0;
        Console.WriteLine("Yes");

        for (int j = 2; j <= num; j+=2)
        {
            sumEven += j;
            Console.Write($"{j} ");
        }
        for (int j = 1, k = 1; k < (num / 2); j += 2, k++)
        {
            sumOdd += j;
            Console.Write($"{j} ");
        }
        Console.WriteLine($"{sumEven - sumOdd}");
    }
    else
    {
        Console.WriteLine("No");
    }
}