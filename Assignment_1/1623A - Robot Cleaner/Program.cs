int loop = int.Parse(Console.ReadLine());

for (int i = 0; i < loop; i++)
{
    int[] array = Console.ReadLine()
        .Split(' ')
        .Select(int.Parse)
        .ToArray();
    int counter = 0;
    bool row = true;
    bool column = true;
    while (true)
    {
        if (array[2] == array[4] || array[3] == array[5])
        {
            Console.WriteLine(counter);
            break;
        }
        else
        {
            if (array[2] < array[0] && row == true)
            {
                array[2]++;
            }
            else
            {
                row = false;
                array[2]--;
                if (array[2] == 0)
                {
                    row = true;
                }

            }

            if (array[3] < array[1] && column == true)
            {
                array[3]++;
            }
            else
            {
                row = false;
                array[3]--;
                if (array[3] == 0)
                {
                    column = true;
                }
            }
            counter++;
        }
    }
}