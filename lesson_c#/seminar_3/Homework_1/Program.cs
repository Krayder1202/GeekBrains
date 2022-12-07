//  Домашка 1

Console.WriteLine("Input number");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine("Profit");
  }
  else Console.WriteLine("No Profit");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine("error");