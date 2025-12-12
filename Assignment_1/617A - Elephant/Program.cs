string input = Console.ReadLine();
int num = int.Parse(input);
int counter = 0;
while (num != 0)
{
    if (num >= 5)
    {
        counter += (num/5);
        num %= 5;
    }
    else if (num >= 4)
    {
        counter += (num/4);
        num %= 4;
    }
    else if (num >= 3)
    {
        counter += (num/3);
        num %= 3;
    }
    else if (num >= 2)
    {
        counter += (num/2);
        num %= 2;
    }
    else
    {
        num %= 1;
        counter++;
    }
}
Console.WriteLine(counter);