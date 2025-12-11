string[] input = Console.ReadLine().Split();
int price  = int.Parse(input[0]);
int dollars  = int.Parse(input[1]);
int banana = int.Parse(input[2]);
int fullPrice = 0;

for  (int i = 1; i <= banana; i++)
{
    fullPrice += price * i;
}
if (fullPrice - dollars > 0)
{
    Console.WriteLine(fullPrice - dollars);
}
else
{
    Console.WriteLine(0);
}