string input = Console.ReadLine();
int cash = int.Parse(input);
int counter = 0;
while (cash != 0)
{
    if (cash >= 100)
    {
        counter += cash / 100;
        cash %= 100;
    }
    else if (cash >= 20)
    {
        counter += cash / 20;
        cash %= 20;
    }
    else if (cash >= 10)
    {
        counter += cash / 10;
        cash %= 10;
    }
    else if (cash >= 5)
    {
        counter += cash / 5;
        cash %= 5;
    }
    else if (cash >= 1)
    {
        counter += cash / 1;
        cash %= 1;
    }
}
Console.WriteLine(counter);