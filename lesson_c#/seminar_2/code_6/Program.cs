Console.WriteLine("Input first number");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Input second number");
int secondNumber = int.Parse(Console.ReadLine());

if(firstNumber == Math.Pow(secondNumber, 2) || secondNumber == Math.Pow(firstNumber, 2))
{
System.Console.WriteLine("Profit");
}
else
{
    System.Console.WriteLine("No Profit");
}