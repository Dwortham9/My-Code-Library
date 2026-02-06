Random rnd = new Random();
int x = 10;
int y = 8;
int[,] array2D = new int[10, 8];
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++) 
    { 
        array2D[i, j] = rnd.Next(1, 10000);
        Console.Write("{0}, ", array2D[i, j]);
    }
    Console.Write("\n");
}
int min = array2D[0, 0];
int max = array2D[0, 0];
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        if (array2D[i, j] > max)
        {
            max = array2D[i, j];
        }

        if (array2D[i, j] < min)
        {
            min = array2D[i, j];
        }

    }

}
Console.WriteLine();
Console.WriteLine("Maximum element:" + max);
Console.WriteLine("Minimum  element:" + min);