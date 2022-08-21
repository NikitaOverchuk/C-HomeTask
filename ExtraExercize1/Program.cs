int[] num = {Convert.ToInt32(Console.ReadLine())};
while (num[0] != 0)                                          //заполняем массив
{
    int n = Convert.ToInt32(Console.ReadLine());
    if (n != 0)
    {
        Array.Resize(ref num, num.Length + 1);
        num[num.Length - 1] = n;
    }
    else
        break;
}
int result = 0;
int start = 0;
int dist = 1;
for (int i = 1; i < num.Length - 1; i++)                   // находим индекс первого локального максимума 
{
    if (num[i] > num[i - 1] && num[i] > num[i + 1])
    {
        start = i;
        break;
    }
}
for (int i = start + 1; i < num.Length - 1; i++)           // ищем расстояние между первым и вторым максимумами, 
{
    if (num[i] > num[i - 1] && num[i] > num[i + 1])
    {
        result = dist;
        dist = 1;
        start = i;
        break;
    }
    dist++;
}
if (result == 0)                                           //чтобы было с чем сравнивать в дальнейшем
    Console.WriteLine(result);
else
{
    for (int i = start + 1; i < num.Length - 1; i++)       // сравниваем расстояния
    {
        if (num[i] > num[i - 1] && num[i] > num[i + 1])
        {
        if (dist < result) result = dist;
        dist = 1;
        continue;
        }
        dist++;
    }
}
Console.WriteLine(result);
