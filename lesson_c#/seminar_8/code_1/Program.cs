int[,] GetArray(int length, int secondLLength)
{
	int[,] array = new int[length, secondLLength];

	var rnd = new Random();

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = rnd.Next(10);
		}
	}

	return array;
}

int[] GetRow(int rowNumber, int[,] array)
{
	int[] row = new int[array.GetLength(0)];

	for (int i = 0; i < array.GetLength(1); i++)
	{
		row[i] = array[rowNumber, i];
	}

	return row;
}

void Update(int[,] array)
{
	int[] first = GetRow(0, array);
	int[] last = GetRow(array.GetLength(0) - 1, array);

	UpdateRow(0, last, array);
	UpdateRow(array.GetLength(0) - 1, first, array);
}

void UpdateRow(int rowNumber, int[] newValue, int[,] array)
{
	for (int i = 0; i < array.GetLength(1); i++)
	{
		array[rowNumber, i] = newValue[i];
	}
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}

int[,] array = GetArray(5, 5);
PrintArray(array);
Console.WriteLine();
Update(array);
PrintArray(array);