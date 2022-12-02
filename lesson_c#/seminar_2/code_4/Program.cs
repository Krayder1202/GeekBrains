Console.WriteLine("Input first number");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Input second number");
int secondNumber = int.Parse(Console.ReadLine());
int result = firstNumber%secondNumber;
if (result== 0)
{
    System.Console.WriteLine("profit");
}
else
{
    System.Console.WriteLine("No Profit " + result); 
}


