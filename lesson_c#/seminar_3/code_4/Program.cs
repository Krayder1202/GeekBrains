// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N

Console.WriteLine("Input number");
int number = int.Parse(Console.ReadLine());
int j= 1;

while (j<=number)
{
    System.Console.WriteLine(Math.Pow (j, 2));
    j++;
}
