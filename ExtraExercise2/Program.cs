int n = Convert.ToInt32(Console.ReadLine());
int[] num = new int[n];
for (int i = 0; i < n; i++)
{
    num[i] = Convert.ToInt32(Console.ReadLine());
}
int result = num[n - 1] + num[0] + num[1];
if (result < num[n - 2] + num[n - 1] + num[0]) result = num[n - 2] + num[n - 1] + num[0];
for (int i = 1; i < n - 1; i++)
{
    int k = num[i - 1] + num[i] + num[i + 1];
    if (k > result) result = k;
}
Console.WriteLine(result);
