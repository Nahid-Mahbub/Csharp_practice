using System.Diagnostics.Metrics;

Console.WriteLine("Hello World!");

// First Array
int[] array = new int[5];
array[0] = 1;
array[1] = 2;
array[2] = 3;
array[3] = 4;
array[4] = 5;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(array[i]);
}

// Second Array
int[,] array2 = new int[4, 5];
int counter = 0;
for  (int i = 0;i < 4; i++)
{
    for (int j = 0;j < 5; j++)
    {
        array2[i, j] = counter;
        counter++;
    }
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(array2[i, j]);
    }
    Console.WriteLine();
}

// Third Array
int[][] jagged = new int[4][];
jagged[0] = new int[1];
jagged[1] = new int[2];
jagged[2] = new int[3];
jagged[3] = new int[4];

// Conditonal statment
int age = 17;

if (age > 17)
{
    Console.WriteLine("You are eligiblem for the program");
}
else if (age == 17)
{
    Console.WriteLine("You are still not eligible");
}
else
{
    Console.WriteLine("You are not eligible for the program");
}

switch(age)
{
    case 15:
        Console.WriteLine("This is 15");
        break;
    case 16:
        Console.WriteLine("This is 16");
        break;
    case 17:
        Console.WriteLine("This is 17");
        break;
    case 18:
        Console.WriteLine("This is 18");
        break;
}


int index = 0;
while(index <= age)
{
    Console.WriteLine($"Current age: {index}");
    index++;
}
index = 0;

do
{
    Console.WriteLine($"Current age: {index}");
    index++;
} while(index > age);

foreach(int num in array)
{
    Console.WriteLine(num);
}

    