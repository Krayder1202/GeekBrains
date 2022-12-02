Console.WriteLine("скажи день?"); //вывод на экран сообщения//
int number=int.Parse(Console.ReadLine()); //ввод в терминал первого значения//

switch (number)
{
    case 1:
        Console.WriteLine("Понедельник"); //вывод на экран сообщения//
        break;
    case 2:
        Console.WriteLine("Вторник");//вывод на экран сообщения//
        break;
    case 3:
        Console.WriteLine("Среда"); //вывод на экран сообщения//
        break;
    case 4:
        Console.WriteLine("Четверг"); //вывод на экран сообщения//
        break;
    case 5:
        Console.WriteLine("Пятницв"); //вывод на экран сообщения//
        break;
    case 6:
        Console.WriteLine("Суббота"); //вывод на экран сообщения//
        break;
    case 7:
        Console.WriteLine("Воскресенье"); //вывод на экран сообщения//
        break;
}
