int n = Convert.ToInt32(Console.ReadLine());
int[] num = new int[n];
for (int i = 0; i < n; i++)
    num[i] = new Random().Next(0, 11);
Console.WriteLine(string.Join(", ", num));
int res = 0;
for (int i = 1; i < n; i += 2)
    res += num[i];
Console.WriteLine(res);
