Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        num[i, j] = new Random().Next(0, 11);
        Console.Write(num[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n - 1; j++)
    {
        int minJ = j;
        for (int k = j + 1; k < n; k++)
        {
            if(num[i, minJ] > num[i, k]) minJ = k;
        }
        int temp = num[i, j];
        num[i, j] = num[i, minJ];
        num[i, minJ] = temp;
        Console.Write(num[i, j] + "\t");
    }
    Console.WriteLine(num[i, n - 1]);
}
