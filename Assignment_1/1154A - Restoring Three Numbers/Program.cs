int[] input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();
Array.Sort(input);

Console.Write(input[3] - input[0]);
Console.Write(" ");
Console.Write(input[3] - input[1]);
Console.Write(" ");
Console.Write(input[3] - input[2]);
