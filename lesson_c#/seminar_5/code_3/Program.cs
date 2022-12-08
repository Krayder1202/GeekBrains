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
