Random rnd = new Random();

int number = rnd.Next(10, 100);

int firstPart = number / 10;
int secondPart = number % 10;

Console.WriteLine(number);

if (firstPart > secondPart)
{
	Console.WriteLine(firstPart);
}
else
{
	Console.WriteLine(secondPart);
}
