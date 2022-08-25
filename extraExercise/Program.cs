int n = Convert.ToInt32(Console.ReadLine());
int[, ] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        int k = new Random().Next(0, 11);
        matrix[i, j] = k;
        Console.Write(k + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[, ] tMatrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        tMatrix[i, j] = matrix[j, i];
        Console.Write(tMatrix[i, j] + "\t");
    }
    Console.WriteLine();
}
