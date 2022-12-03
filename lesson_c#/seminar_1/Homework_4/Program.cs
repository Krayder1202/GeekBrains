// Домашка 4 (работает идеально)

Console.WriteLine("введите число"); //вывод на экран сообщения
int i= int.Parse(Console.ReadLine()); // задаем число
int j = 1;
while (j <= i)
{
    int result = j % 2;
    if (result != 1)
    {
    Console.WriteLine("четное " + j);
    j++;       
    }
    else
    {        
        j++;
    }
}
