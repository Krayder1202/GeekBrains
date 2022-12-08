void Task2()
{
	int i = ReadInt();
	int j = ReadInt();

	Console.WriteLine(i > j ? "i > j" : "j > i");
}



void Task4()
{
	int i = ReadInt();
	int j = ReadInt();
	int k = ReadInt();

	Console.WriteLine($"Max is {GetMax(i, j, k)}");
}

void Task6()
{
	int i = ReadInt();

	if (IsEven(i))
		Console.WriteLine("Number is even");
	else
		Console.WriteLine("Ha ha");
}

void Task8()
{
	int n = ReadInt();

	for (int i = 0; i <= n; i++)
		if (IsEven(i))
			Console.Write($"{i}, ");
}

void Task10()
{
	int n = ReadInt();

	if (IsThreeNumber(n))
	{
		Console.WriteLine((n / 10) % 10); //Console.WriteLine(n.ToString()[1]);
	}
}

void Task13()
{
	int n = ReadInt();

	if (n > 99)
		while (!IsThreeNumber(n))
			n = n / 10;
	else
		Console.WriteLine("Oops");

	Console.WriteLine(n % 10);
}

void Task15()
{
	int n = ReadInt();

	if (n < 6) Console.WriteLine("Working");
	else if (n < 8) Console.WriteLine("Holliday");
	else Console.WriteLine("Not a day");
	//switch (n)
	//{
	//	case 6:
	//	case 7: Console.WriteLine("Holliday"); break;
	//	default: Console.WriteLine("It's not a holliday or not a day"); break;
	//}
}

void Task23()
{
	int n = ReadInt();

	for (int i = 0; i < n; i++)
	{
		Console.Write($"{Math.Pow(i, 3)}, ");
	}
}

void Task25()
{
	int n = ReadInt();
	int result = 1;

	for (int i = 0; i < n; i++)
	{
		result = result * n;
	}

	Console.WriteLine(result);
}

void Task27()
{
	int n = ReadInt();
	int result = 0;
	GetSumm(ref n, ref result);

	Console.WriteLine(result);
}


int ReadInt()
{
	Console.WriteLine("Enter a number");

	if (int.TryParse(Console.ReadLine(), out int i)) // 6, number
	{
		return i;
	}

	Console.WriteLine("It's not a number");

	return -1;
}

int GetMax(params int[] numbers)
{
	int max = 0;

	foreach (int item in numbers)
	{
		if (item > max)
			max = item;
	}

	// for (int i = 0; i < numbers.Length; i++) {... numbers[i]}

	return max;
}

bool IsEven(int i)
{
	return i % 2 == 0;
}

bool IsThreeNumber(int i)
{
	return i >= 100 && i < 1000;
}

static void GetSumm(ref int n, ref int result)
{
	while (n / 10 > 0)
	{
		result = result + n % 10; // i++ = i + 1 // i+=5  --- i = i +5
		n = n / 10;
	}
}