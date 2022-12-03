// Домашка 2 (Работает, но не идельно)

Console.WriteLine("Input first number");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Input second number");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Input third number");
int c = int.Parse(Console.ReadLine());
int max = 0;

if (a<=b)
{
    max=b;
    
    if (max<=c)
    {
        max=c;
        System.Console.WriteLine(max);
    }
    else
    {
        max=b;
        System.Console.WriteLine(max);
    }
}
else
{
    max=a;
    System.Console.WriteLine(max);
}