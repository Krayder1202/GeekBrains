// Домашка 2 (будут по ней вопросы на семинаре)

System.Console.WriteLine("input number ");

int Number = int.Parse(Console.ReadLine());
string NumberText = Convert.ToString(Number);

if (NumberText.Length > 2)
{
  System.Console.WriteLine("третья цифра " + NumberText[2]);
}
else {
  System.Console.WriteLine("No Profit");
}