Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int k = Convert.ToInt32(Console.ReadLine());
string res = String.Empty;
int[,] num = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        num[i, j] = new Random().Next(-100, 100);
        Console.Write(num[i, j] + "\t");
    }
    Console.WriteLine(); 
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (num[i, j] == k) 
        {
            res = Convert.ToString(i) + " " + Convert.ToString(j);
            break;
        }
    }
}
if (res == String.Empty) Console.WriteLine("Такого числа нет");
else Console.WriteLine(res);
