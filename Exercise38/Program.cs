int n = Convert.ToInt32(Console.ReadLine());
double[] num = new double[n];
double maxNum = Convert.ToDouble(Console.ReadLine());
double minNum = maxNum;
for (int i = 1; i < n; i++)
{
    double k = Convert.ToDouble(Console.ReadLine());
    if (k > maxNum) maxNum = k;
    if (k < minNum) minNum = k;
    num[i] = k;
}
Console.WriteLine("[" + string.Join(", ", num) + "]");
Console.WriteLine(maxNum - minNum);
