Console.WriteLine( "Введите число : " );
int num = int.Parse(Console.ReadLine());
int Factorial (int num)
{
int result=1;
for (int i=1; i <= num; i++)
{
   result=result *i;
}
return result;
}

System.Console.WriteLine(Factorial(num));