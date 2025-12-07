using System.Collections.Generic;
using System.Runtime.InteropServices;
List<int> dynamicArray = new List<int>();
var value1 = "2042894829088403450953902849827960782045872349823839287429842498";
var value2 = "9328342938798342723489542789232498479823447823849823449872343";
var answer = "2052223172027201793677392392617193280525695797647689110879714841";
int value3 = 0;
int temp = 0;

if (value1.Length < value2.Length)
{
    string temporay = value1;
    value1 = value2;
    value2 = temporay;
}

for (int i = (value1.Length) - 1, j = (value2.Length) - 1; i >= 0 || j >= 0; i--, j--)
{
    if (j < 0)
    {
        value3 = value1[i] - '0' + temp;
        temp = 0;
        if ((value3 - 10) >= 0)
        {
            dynamicArray.Insert(0, value3 - 10);
            temp = 1;
        }
        else
        {
            dynamicArray.Insert(0, value3);
        }
        Console.WriteLine(dynamicArray[0]);
        Console.WriteLine($"{i}, {j}");
        continue;
    }
    value3 = (value1[i] - '0') + (value2[j] - '0');
    value3 += temp;
    temp = 0;
    
    if ((value3 - 10) >= 0)
    {
        dynamicArray.Insert(0, value3 - 10);
        temp = 1;
    }
    else
    {
        dynamicArray.Insert(0, value3);
    }
    Console.WriteLine($"{i}, {j}");
    
}
Console.Write("Final answer: ");
foreach (int Val in dynamicArray)
{
    Console.Write(Val);
}