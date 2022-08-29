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
string res = string.Empty;
for (int j = 0; j < n; j++)
{
    double summa = 0;
    for(int i = 0; i < m; i++)
    {
        summa += num[i, j];                    //
    }
    res += Convert.ToString(summa / m) + " ";
}
Console.WriteLine("Среднее арифметическое каждого столба: " + res);
