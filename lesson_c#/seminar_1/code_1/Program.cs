Console.WriteLine("one numbers?"); //вывод на экран сообщения//
int a=int.Parse(Console.ReadLine()); //ввод в терминал первого значения//
Console.WriteLine("second numbers?"); //вывод на экран сообщения//
int b=int.Parse(Console.ReadLine()); //ввод в терминал второго значения//
if (a==b*b) //задаем условия//
    {
        Console.WriteLine("Profit"); //вывод на экран при верных значениях//
    }
    else
{
        Console.WriteLine("Не Profit"); //вывод на экран при неверных значениях//
}