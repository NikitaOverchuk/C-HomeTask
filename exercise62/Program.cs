Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[, ] num = new int[m, n];                     // flag - направление
int i = 0;                                       // 1 - направление слева направо
int j = 1;                                       // 2 - направление сверху вниз
num[0, 0] = 1;                                   // 3 - справа налево
int flag = 1;                                    // 4 - снизу вверх
while (num[i, j] == 0)                           //остановка цикла - после поворота направо число не равно 0       
{
    if (flag == 1)
    {
        num[i, j] = num[i, j - 1] + 1;                          //текущее - это прошлое + 1
        if (j == n - 1 || num[i, j + 1] != 0)                   // если доходим до края или до следующего нуля
        {
            i += 1;                                             // поворачиваем, сразу делаем шаг и меняем направление
            flag = 2;
        }                 
        else j += 1;                                            // просто идем вперед по направлению
    }
    if (flag == 2)
    {
        num[i, j] = num[i - 1, j] + 1;
        if (i == m - 1 || num[i + 1, j] != 0)
        {
            j -= 1;
            flag = 3;
        }               
        else i += 1;
    }
    if (flag == 3)
    {
        num[i, j] = num[i, j + 1] + 1;
        if (j == 0 || num[i, j - 1] != 0)                
        {
            i -= 1;
            flag = 4;
        }                
        else j -= 1;    
    }
    if (flag == 4)    
    {
        num[i, j] = num[i + 1, j] + 1;
        if (num[i - 1, j] != 0)
        {
            j += 1;
            flag = 1;
        }                
        else i -= 1;  
    }
}
for (int g = 0; g < m; g++)
{
    for (int l = 0; l < n; l++)
    {
        Console.Write(num[g, l] + "\t");
    }
    Console.WriteLine();
}
