// Домашка 3 (еще одна версия)

System.Console.WriteLine("input number");
int number=int.Parse(Console.ReadLine());

if (number == 6 || number == 7) 
{
System.Console.WriteLine("Profit");
}
else 
if (number < 1 || number > 7) 
{
  System.Console.WriteLine("это вообще не день недели");
}
else System.Console.WriteLine("No Profit");

