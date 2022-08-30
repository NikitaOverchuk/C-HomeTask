Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[m, n];
int result = 0;
int stroka = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        num[i, j] = new Random().Next(0, 11);
        Console.Write(num[i, j] + "\t");
    }
    Console.WriteLine();
}
for (int j = 0; j < n; j++)          // сохраняем первую строку
{
    result += num[0, j];
}

for (int i = 1; i < m; i++)
{
    int summa = 0;
    for (int j = 0; j < n; j++)
    {
        summa += num[i, j];
    }
    if (summa < result)
    {
        result = summa;
        stroka = i;
    }
}
Console.WriteLine((stroka + 1) + " строка");
