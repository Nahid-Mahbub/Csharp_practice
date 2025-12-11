string[] input = Console.ReadLine().Split();
var a = int.Parse(input[0]);
var b = int.Parse(input[1]);
int counter = 0;
while (a <= b)
{
    a *= 3;
    b *= 2;
    counter++;
}
Console.WriteLine(counter);