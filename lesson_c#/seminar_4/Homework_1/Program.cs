//  Домашка 1

Console.WriteLine(Calculate(3, 5));
int Calculate (int firstNumber, int secondNumber)

{
  int result = 1;
  for(int i=1; i <= secondNumber; i++)
  {
    result = result * firstNumber;
  }
   
    return result;
}