string MetodFor(int a, int b)
{
	string result = String.Empty;
	for (int i = a; i <= b; i++)
	{
		result += $"{i} ";
	}
	return result;
}
Console.WriteLine(MetodFor(1, 10));

//Метод с рекурсией
string MetodRecursion (int a, int b)
{
	if (a <= b) return $"{a} " + MetodRecursion(a + 1, b);
	else return string.Empty;
}
Console.WriteLine(MetodRecursion(ReadInt(), ReadInt()));

int ReadInt()
{
    Console.WriteLine("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out int i))
        return i;
    else
    {
        Console.WriteLine("Это не число: ");
        return -1;
    }

}