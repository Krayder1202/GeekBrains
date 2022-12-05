// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int quarter = int.Parse(Console.ReadLine()!);

if (quarter == 1)
{
    Console.WriteLine("от Х = 1, Y =1 "); 
}
else if (quarter == 2)
{
    Console.WriteLine("от Х = -1, Y =1 ");
}
else if (quarter == 3)
{
    Console.WriteLine("от Х = -1, Y = -1"); 
}
else if (quarter == 4)
{
    Console.WriteLine("от Х = 1, Y = -1"); 
}
else
{
    Console.WriteLine("No Profit");
}
