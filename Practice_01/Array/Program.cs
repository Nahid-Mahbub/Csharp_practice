int[] ages = new int[10];
int[] ages2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] ages3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

ages[0] = 22;
ages[1] = 23;
// ...
// ...
ages[9] = 30;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(ages2[i]);
}

int[,] Martix = new int[2, 2];
Martix[0, 0] = 0;
Martix[0, 1] = 1;
Martix[1, 0] = 2;
Martix[1, 1] = 3;

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(Martix[i, j]);
    }
    Console.WriteLine();
}

int[][] jaggedArray = new int[4][]; // We have to give only Row value in jaggedArray, and jaggedArray means array of arrays.
jaggedArray[0] = new int[] { 1, 2, 3};
jaggedArray[1] = new int[] { 4, 5, 6, 7};
jaggedArray[2] = new int[] { 8 };
jaggedArray[3] = new int[] { 9, 10, 11, 12, 13 };

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j]);
    }
    Console.WriteLine();
}
