int n = Convert.ToInt32(Console.ReadLine());
int[] num = new int[n];
int res = 0;
for (int i = 0; i < n; i++)
{
    //int k = new Random().Next(-10, 11);
    num[i] = new Random().Next(-10, 11);
}
Console.WriteLine("[" + string.Join(", ", num) + "]");
for (int i = 1; i < n; i += 2)
{
    res += num[i];
}
Console.WriteLine(res);
