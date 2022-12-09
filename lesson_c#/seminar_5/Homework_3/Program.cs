// Домашка 3
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
int[] array = {17,64,53,73,47,365,63,25,93,};

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
System.Console.Write($"максимальное число ");
Console.WriteLine(max);

int Min (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2<result) result = arg2;
    if (arg3<result) result = arg3;
    return result;
}

int min = Min (
    Min(array[0], array[1], array[2]),
    Min(array[3], array[4], array[5]),
    Min(array[6], array[7], array[8])
);
System.Console.Write($"минимальное число ");
Console.WriteLine(min);

int sum = max- min;
System.Console.Write("разница между ними ");
Console.WriteLine(sum);
