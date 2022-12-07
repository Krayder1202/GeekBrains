// Домашка 2

Console.WriteLine("input number?");

double ax = double.Parse(Console.ReadLine()!);
double ay = double.Parse(Console.ReadLine()!);
double az = double.Parse(Console.ReadLine()!);
double bx = double.Parse(Console.ReadLine()!);
double by = double.Parse(Console.ReadLine()!);
double bz = double.Parse(Console.ReadLine()!);

double ab = Math.Pow ( bx- ax, 2) + Math.Pow (by - ay, 2) + Math.Pow (bz - az, 2); // возведение в степень

ab = Math.Sqrt (ab); //вычесление квадратного корня
ab = Math.Round (ab, 3); //округление
System.Console.WriteLine($"input number {ab}");
