//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("input number?");

double ax = double.Parse(Console.ReadLine()!);
double ay = double.Parse(Console.ReadLine()!);
double bx = double.Parse(Console.ReadLine()!);
double by = double.Parse(Console.ReadLine()!);

double ab = Math.Pow (bx-ax, 2)+ Math.Pow (by - ay, 2); // возведение в степень

ab = Math.Sqrt (ab); //вычесление квадратного корня
ab = Math.Round (ab, 3); //округление
System.Console.WriteLine($"input number {ab}");