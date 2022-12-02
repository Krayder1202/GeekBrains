Random rnd = new Random();

int number = rnd.Next(100, 1000);

int firstPart = number / 100;
int secondPart = number % 10;

System.Console.WriteLine(number);

int FinalNumber = (firstPart*10)+secondPart;

Console.WriteLine(FinalNumber);
