Console.WriteLine("Input number");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    System.Console.WriteLine($"{i} в квадрате = {Math.Pow(i, 2)}");
}
