Console.WriteLine($"Введите количество интервалов");
int N;
N = Convert.ToInt32(Console.ReadLine());
int[] array0 = new int[(int)Math.Pow(10, 9)];
int count = 0;
int[,] array1 = new int[2, N];
Random rand = new Random();
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
    array1[0, i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"До");
    array1[1, i] = Convert.ToInt32(Console.ReadLine());
    if (array1[1, i] < array1[0, i])
    {
        count--;
        Console.WriteLine($"Второе число должно быть больше первого");
    }
    count++;
}
for (int i = 0; i < N; i++)
{
    count = array1[0, i];
    do
    {
        if (array0[count] == 0) array0[count] = 1; else array0[count] = 0;
        count++;
    }
    while (count < array1[1, i]);
}
count = 0;
int temp = 0;
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