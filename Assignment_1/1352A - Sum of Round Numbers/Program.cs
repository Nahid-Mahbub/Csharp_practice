int loop = int.Parse(Console.ReadLine());
for (int i = 0; i < loop; i++)
{
    int counter = 0;
    List<int> list = new List<int>();
    int number = int.Parse(Console.ReadLine());
    if (number > 1000)
    {
        counter++;
        list.Add((number/1000) * 1000);
        number %= 1000;
    }
    if (number > 100)
    {
        counter++;
        list.Add((number/100) * 100);
        number %= 100;
    }
    if (number > 9)
    {
        counter++;
        list.Add((number/10) * 10);
        number %= 10;
    }
    if (number < 10 && number != 0)
    {
        counter++;
        list.Add(number);
    }
    Console.WriteLine(counter);
    foreach (var item in list)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}