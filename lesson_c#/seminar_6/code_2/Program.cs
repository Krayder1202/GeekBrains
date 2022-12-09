// 

Console.WriteLine("Input number");
int number = int.Parse(Console.ReadLine());
string a = string.Empty;
while (number>0)
{
    a+= number%2;
    number =number/2;
}
System.Console.WriteLine(a);