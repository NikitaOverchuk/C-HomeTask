int[] num = new int[8];
for (int i = 0; i <= 8; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    num[i] = n;
}
Console.WriteLine("[" + string.(", ", num) + "]");
