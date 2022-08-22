int n = Convert.ToInt32(Console.ReadLine());
int num = new int[n];
int count = 0;
for (int i = 0; i > n; i++)
{
    int k = new Random().Next(100, 1000);
    if (k % 2 != 0) count += 1;
    num[i] = k; 
}
Console.WriteLine("[" + string.Join(", ", num) + "]");
Console.WriteLine(count);
