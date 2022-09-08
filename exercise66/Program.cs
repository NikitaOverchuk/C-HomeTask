int f(int m, int n)
{
    if (n == m) return m;
    return n + f(n - 1);
}

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));
