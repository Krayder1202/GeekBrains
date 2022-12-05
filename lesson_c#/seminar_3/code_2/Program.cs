//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("input number?"); //вывод на экран сообщения//
int number=int.Parse(Console.ReadLine()); //ввод в терминал первого значения//

switch (number)
{
    case 1:
        number = 1;
        Console.WriteLine("от Х = 1, Y =1 "); //вывод на экран сообщения//
        break;
    case 2:
        number = 2;
        Console.WriteLine("от Х = -1, Y =1 ");//вывод на экран сообщения//
        break;
    case 3:
        number = 3;
        Console.WriteLine("от Х = -1, Y = -1"); //вывод на экран сообщения//
        break;
    case 4:
    number = 4;
        Console.WriteLine("от Х = 1, Y = -1"); //вывод на экран сообщения//
        break;
}