Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] num1 = new int[m, n];
int[,] num2 = new int[m, n];
int[,] numResult = new int[m, n];
for (int i = 0; i < m; i++)                            //заполняем первую матрицу
{
    for (int j = 0; j < n; j++)
    {
        num1[i, j] = new Random().Next(0, 11);
        Console.Write(num1[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < m; i++)                             // заполняем вторую матрицу
{
    for (int j = 0; j < n; j++)
    {
        num2[i, j] = new Random().Next(0, 11);
        Console.Write(num2[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < m; i++)                             // выводим результ
{
    for (int j = 0; j < n; j++)
    {
        numResult[i, j] = num1[i, j] * num2[i , j];
        Console.Write(numResult[i, j] + "\t");
    }
    Console.WriteLine();
}