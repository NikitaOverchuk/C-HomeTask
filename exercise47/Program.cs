int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] num = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        num[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        Console.Write(num[i, j] + "\t");
    }
    Console.WriteLine();
}
