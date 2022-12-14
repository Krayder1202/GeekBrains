i, j]} ");
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