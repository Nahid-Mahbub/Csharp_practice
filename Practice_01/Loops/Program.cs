// For loops

for (int i = 0, j = 10; i < 10 && j > 0; i++, j--)
{
    Console.Write(i + " ");
    Console.WriteLine( j);
}

int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(x);

for (int i = 1; i <= x; i++)
{
    Console.WriteLine("This is for loop " + i);
}

int index = 1;
while (index <= x)
{
    Console.WriteLine("This is while loop " + index);
    index++;
}

int doindex = 1;
do
{
    Console.WriteLine("This is from do while " + doindex);
    doindex++;
} while (doindex <= x) ;

int[] value = [22, 40, 45];
var sum = 0;
foreach (var num in value)
{
    sum += num;
    Console.WriteLine(sum);
}

Console.WriteLine("End of loops");