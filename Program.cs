start:
Console.WriteLine($"Введите количество интервалов");
int N;
N = Convert.ToInt32(Console.ReadLine());
if (N > 500 || N < 1)
{
    Console.Clear();
    Console.WriteLine($"Ошибка ввода");
    goto start;
}
int[] array0 = new int[(int)Math.Pow(10, 9)];
int count = 0;int x; int y; int temp = 0;
//Random rand = new Random();
//for (int i = 0; i < N; i++)
//{
//    array1[0, i] = rand.Next(0, (int)Math.Pow(10, 9));
//    do array1[1, i] = rand.Next(0, (int)Math.Pow(10, 9));
//    while (array1[1, i] < array1[0, i]);
//}  
Console.WriteLine($"Введите {N} интервалов");
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введите {count + 1} Интервал");
    Console.WriteLine($"От");
    x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"До");
    y = Convert.ToInt32(Console.ReadLine());
    if (y < x|| x > Math.Pow(10, 9) || y > Math.Pow(10, 9) || x < 0 || y < 0)
    {
        Console.WriteLine($"Ошибка ввода");
        i--;
        count--;
    }
    else
    {
        do
        {
            if (array0[x] == 0) array0[x] = 1; else array0[x] = 0;
            x++;
        }
        while (x < y);
        x = -1; y = -1;
    }
    count++;
}
count = 0;
foreach (int i in array0)
{
    if (i == 0) count++;
    else
    {
        if (count > temp) temp = count;
        count = 0;
    }
}
if (count > temp) temp = count;
Console.WriteLine($"Самый большой белый интервал");
Console.WriteLine(temp);