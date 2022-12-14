int[,] inputTwoDimenstions(int length, int secondLength)
{
    int[,] mass = new int[length, secondLength];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        FillDimenstion(i, mass);
    }
    return mass;
}

int ReadInt()
{
    Console.WriteLine("Input number");
    int a = int.Parse(Console.ReadLine());
    return a;
}

void FillDimenstion(int index, int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(1); i++)
    {
        massiv[index, i] = new Random().Next(1, 10);
    }
}

void GetArrayAsString(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}
void Replace(int[,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            if ((i+1) % 2==0 && (j+1) % 2 == 0) 
            
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }

    }
      
}

Task();
void Task()
{
    int[,] array = inputTwoDimenstions(ReadInt(), ReadInt());
    GetArrayAsString(array);
    Console.WriteLine();
    Replace(array);
    GetArrayAsString(array);
}