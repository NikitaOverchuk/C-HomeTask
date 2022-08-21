int n = Convert.ToInt32(Console.ReadLine());
int res = 0;
while (n != 0)
{
    res += n % 10;
    n = n / 10;
}
Console.WriteLine(res);
