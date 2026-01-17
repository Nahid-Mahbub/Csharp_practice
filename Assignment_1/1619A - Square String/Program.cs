int loop = int.Parse(Console.ReadLine());
for (int i = 0; i < loop; i++)
{
    string s = Console.ReadLine();
    int len = s.Length;
    if (len % 2 != 0)
    {
        Console.WriteLine("NO");
        continue;
    }
    else
    {
        string firstHalf = s.Substring(0, len / 2);
        string secondHalf = s.Substring(len / 2, len / 2);
        if (firstHalf == secondHalf)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

}