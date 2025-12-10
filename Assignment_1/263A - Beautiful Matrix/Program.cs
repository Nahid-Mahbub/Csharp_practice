int[,] metirx = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    string input = Console.ReadLine();
    string[] parts = input.Split(' ');

    metirx[i, 0] = int.Parse(parts[0]);
    metirx[i, 1] = int.Parse(parts[1]);
    metirx[i, 2] = int.Parse(parts[2]);
    metirx[i, 3] = int.Parse(parts[3]);
    metirx[i, 4] = int.Parse(parts[4]);
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (metirx[i, j] == 1)
        {
            int output = 0;
            output = Math.Abs(2 - i);
            output += Math.Abs(2 - j);
            Console.WriteLine($"{output}");
        }
    }
}