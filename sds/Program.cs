int n = Convert.ToInt32(Console.ReadLine());
int[] num = new int[n];
int res = 0;
for (int i = 0; i < n; i++)
{
    int k = Convert.ToInt32(Console.ReadLine());
    if (k > 0) res += 1;
    num[i] = k;
}
Console.WriteLine(string.Join(", ", num));
Console.WriteLine(res);
