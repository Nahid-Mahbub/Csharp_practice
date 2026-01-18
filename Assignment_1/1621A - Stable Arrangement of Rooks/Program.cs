using System.Diagnostics.Metrics;

int loop = int.Parse(Console.ReadLine());

for (int i = 0; i < loop; i++)
{
    int[] array = Console.ReadLine()
        .Split(' ')
        .Select(int.Parse)
        .ToArray();
    
    if(Math.Ceiling(array[0] / 2.0) >= array[1])
    {
        int counter = 0;
        for (int j = 1; j <= array[0]; j++)
        {
            for (int k = 1; k <= array[0]; k++)
            {
                if (j == k && (k % 2) != 0 && counter < array[1])
                {
                    Console.Write('R');
                    counter++;
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
        
    else
        Console.WriteLine("-1");
}