// Домашка 2

//Console.WriteLine("Input number");
//int number = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int number)
  {
    
    int x = Convert.ToString(number).Length;
    int y = 0;
    int result = 0;

    for (int i = 0; i < x; i++){
      y = number - number % 10;
      result = result + (number - y);
      number = number / 10;
    }
   return result;
  }
int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);