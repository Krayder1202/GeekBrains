int Revers(int [] array1)
	{
		for (int i = 0; i < array1.Length/2; i++)
		{
			ChengeElements(array1, i, array1.Length-1-i);
		}
	}

int [] Array(int length)
	{
		int [] array = new int[length];
		for (int i = 0; i < length; i++)
		{
		{
			array [i] =i;
		}
		return array;
		}
	}

string GetArray(int[] array)
	{
		string result = string.Empty;
		for (int i = 0; i < array.Length; i++)
		{
			result += $"{array[i]}  ";
		}
		return result;
	}

void ChengeElements(int [] array, int index1, int indexL)
	{
		int temp = array[index1]; 
		array[index1] = array[indexL]; 
		array[indexL] = temp;
	}


int a = Array(10);
System.Console.WriteLine(GetArray(a));

Revers(a);
System.Console.WriteLine(GetArray(a));